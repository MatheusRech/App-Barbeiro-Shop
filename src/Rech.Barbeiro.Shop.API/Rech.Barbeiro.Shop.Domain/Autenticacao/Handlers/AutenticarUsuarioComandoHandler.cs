using MediatR;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Rech.Barbeiro.Shop.API.Helpers.Exceptions;
using Rech.Barbeiro.Shop.Domain.Autenticacao.Comandos;
using Rech.Barbeiro.Shop.Domain.Autenticacao.Options;
using Rech.Barbeiro.Shop.Domain.Autenticacao.Respostas;
using Rech.Barbeiro.Shop.Domain.Usuario;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Rech.Barbeiro.Shop.Domain.Autenticacao.Handlers
{
    public class AutenticarUsuarioComandoHandler : IRequestHandler<AutenticarUsuarioComando, AutenticarUsuarioResposta>
    {
		private readonly ILogger<AutenticarUsuarioComandoHandler> _logger;
        private readonly UserManager<UsuarioEntidade> _userManager;
        private readonly SignInManager<UsuarioEntidade> _signInManager;
        private readonly JwtOptions _jwtOptions;
        public AutenticarUsuarioComandoHandler(ILogger<AutenticarUsuarioComandoHandler> logger, 
                                               UserManager<UsuarioEntidade> userManager,
                                               SignInManager<UsuarioEntidade> signInManager,
                                               IOptions<JwtOptions> options)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtOptions = options.Value;
        }

        public async Task<AutenticarUsuarioResposta> Handle(AutenticarUsuarioComando request, CancellationToken cancellationToken)
        {
			try
			{
                request.Validar();

                var username = string.Concat(request.Cpf, request.BarbeariaId);

                var usuario = await _userManager.FindByNameAsync(username);

                if (usuario is null)
                    return new AutenticarUsuarioResposta(false, erro: "Cpf ou senha incorretos");

                var resultado = await _signInManager.CheckPasswordSignInAsync(usuario, request.Senha, true);

                if (!resultado.Succeeded)
                    return new AutenticarUsuarioResposta(false, erro: "Cpf ou senha incorretos");

                var rolesUsuario = await _userManager.GetRolesAsync(usuario);

                return new AutenticarUsuarioResposta(true, token: GerarTokenParaUsuario(usuario, rolesUsuario));
            }
            catch (DomainException ex)
			{
				return new AutenticarUsuarioResposta(false, erro: ex.Message);
			}
			catch (Exception ex)
			{
                _logger.LogError(ex, "Ocorreu um erro ao tentar autenticar o usuario. Erro: {0}. Stacktrace: {1}", ex.Message, ex.StackTrace);
                return new AutenticarUsuarioResposta(false, erro: $"Ocorreu um erro ao tentar autenticar o usuario. Erro: {ex.Message}. Stacktrace: {ex.StackTrace}");
			}
        }

        private string GerarTokenParaUsuario(UsuarioEntidade usuarioEntidade, IList<string> permissoes)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var agora = DateTime.UtcNow;

            var clains = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, usuarioEntidade.UserName),
                new Claim(ClaimTypes.Email, usuarioEntidade.Email),
            };

            clains.AddRange(permissoes.Select(x => new Claim(ClaimTypes.Role, x)));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(clains),
                Expires = agora.AddHours(2),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.Secret)),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var stoken = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(stoken);
        }
    }
}
