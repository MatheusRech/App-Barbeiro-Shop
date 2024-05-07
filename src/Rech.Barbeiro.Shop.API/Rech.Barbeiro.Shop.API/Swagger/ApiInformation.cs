using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Rech.Barbeiro.Shop.API.Swagger
{
    public class ApiInformation : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiDescriptionGroupCollectionProvider _provider;
        public ApiInformation(IApiDescriptionGroupCollectionProvider provider)
        {
            _provider = provider;
        }

        public void Configure(SwaggerGenOptions options)
        {
            var docs = options.SwaggerGeneratorOptions.SwaggerDocs;

            for (var i = 0; i < _provider.ApiDescriptionGroups.Items.Count; i++)
            {
                var group = _provider.ApiDescriptionGroups.Items[i];

                var groupApiVersion = group.Items[0];

                var title = group.GroupName;
                var index = group.GroupName.IndexOf("_");
                if (index != -1)
                {
                    title = group.GroupName[..index];
                }
                var info = new OpenApiInfo
                {
                    Title = title,
                    Version = groupApiVersion.GetApiVersion().ToString(),
                };

                if (groupApiVersion.IsDeprecated())
                {
                    info.Description += $"{Environment.NewLine}This API version has been deprecated";
                }

                docs.Add(group.GroupName, info);
            } 
        }
    }
}
