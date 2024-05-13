using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Rech.Barbeiro.Shop.API.Helpers.Exceptions;
using Rech.Barbeiro.Shop.Domain.Usuario.Comandos;
using Rech.Barbeiro.Shop.Domain.Usuario.Resposta;

namespace Rech.Barbeiro.Shop.Domain.Usuario.Handlres
{
    public class CadastrarUsuarioComandoHandler : IRequestHandler<CadastrarUsuarioComando, CadastrarUsuarioResposta>
    {
        private readonly UserManager<UsuarioEntidade> _userManager;
        private readonly ILogger<CadastrarUsuarioComandoHandler> _logger;

        public CadastrarUsuarioComandoHandler(UserManager<UsuarioEntidade> userManager, ILogger<CadastrarUsuarioComandoHandler> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        public async Task<CadastrarUsuarioResposta> Handle(CadastrarUsuarioComando request, CancellationToken cancellationToken)
        {
            try
            {
                request.Validar();

                var username = string.Concat(request.Cpf, request.BarbeariaId);

                if (await _userManager.FindByNameAsync(username) is not null)
                    return new CadastrarUsuarioResposta("Usuario já cadastrado");

                var usuario = new UsuarioEntidade(username, request.BarbeariaId);

                usuario.Email = request.Email;

                var resultado = await _userManager.CreateAsync(usuario);

                if (!resultado.Succeeded)
                    return new CadastrarUsuarioResposta(string.Join('\n', resultado.Errors));

                resultado = await _userManager.AddPasswordAsync(usuario, request.Senha);

                if (!resultado.Succeeded)
                    return new CadastrarUsuarioResposta(string.Join('\n', resultado.Errors));

                resultado = await _userManager.AddToRolesAsync(usuario, request.Permissoes);

                if (!resultado.Succeeded)
                    return new CadastrarUsuarioResposta(string.Join('\n', resultado.Errors));

                return new CadastrarUsuarioResposta(usuario.Id);
            }
            catch (DomainException ex)
            {
                return new CadastrarUsuarioResposta(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocorreu um erro ao tentar cadastrar o usuario. Erro: {0}. Stacktrace: {1}", ex.Message, ex.StackTrace);
                return new CadastrarUsuarioResposta($"Ocorreu um erro ao tentar cadastrar o usuario. Erro: {ex.Message}. Stacktrace: {ex.StackTrace}");
            }
        }
    }
}
