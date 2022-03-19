using Microsoft.OpenApi.Models;
using MSUsuario.Application;
using MSUsuario.Data.Sql;
using MSUsuario.Mapping;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
ConfigurationManager configuration = builder.Configuration;

configuration.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

services.AddEndpointsApiExplorer();
services.AddApiVersioning();
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "APIUsuario", Description = "Teste com Minimal APIs", Version = "v1" });
});
services.AddControllers();
services.AddMapping()
        .AddInfraDataSqlServices(configuration)
        .AddApplicationServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "APIUsuario");
    c.RoutePrefix = string.Empty;
});

app.Run();
