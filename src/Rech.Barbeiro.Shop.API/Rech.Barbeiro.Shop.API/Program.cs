using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using Rech.Barbeiro.Shop.API.Config;
using Rech.Barbeiro.Shop.API.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddCors(options =>
{
    options.AddPolicy("localhost",
    builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

#region Versionamento

builder.Services.AddApiVersioning(p =>
{
    p.DefaultApiVersion = new ApiVersion(1, 0);
    p.ReportApiVersions = true;
    p.AssumeDefaultVersionWhenUnspecified = true;
});

builder.Services.AddVersionedApiExplorer(p =>
{
    p.GroupNameFormat = "'v'VVV";
    p.SubstituteApiVersionInUrl = true;
});

#endregion

builder.Services.AddInjecaoDepedencia();
builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddAutenticacao(builder.Configuration);

#region Swagger

builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ApiInformation>();

builder.Services.AddSwaggerGen();
#endregion


var app = builder.Build();

var provider = app.Services.GetService<IApiDescriptionGroupCollectionProvider>();

// Configure the HTTP request pipeline.
app.UseSwagger().UseSwaggerUI(options =>
{
    foreach (var item in provider.ApiDescriptionGroups.Items.OrderBy(x => x.Items[0].GetApiVersion().Status).ThenByDescending(x => x.Items[0].GetApiVersion()).ThenBy(x => x.GroupName))
    {
        options.SwaggerEndpoint($"{item.GroupName}/swagger.json", $"{item.GroupName.ToUpperInvariant()}");
    }


    options.DocExpansion(DocExpansion.List);
});

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
