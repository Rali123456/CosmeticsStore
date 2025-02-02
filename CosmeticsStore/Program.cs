using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using CosmeticsStore.DL.Interfaces;
using CosmeticsStore.DL.Repositories.MongoDb;
using CosmeticsStore.DL.Repositories;
using CosmeticsStore.DL;
using CosmeticsStore.BL.Interfaces;
using CosmeticsStore.BL.Services;
using CosmeticsStore.Models.Requests;
using FluentValidation;
using CosmeticsStore.Validators;
using CosmeticsStore.Models.Configurations;
using FluentValidation.AspNetCore;
using CosmeticsStore.MapConfig;
using CosmeticsStore.ServiceExtensions;
using Mapster;
using Serilog.Sinks.SystemConsole.Themes;
using CosmeticsStore.HealthChecks;

namespace CosmeticsStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Конфигуриране на логиране с Serilog
            var logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Console(theme: AnsiConsoleTheme.Code)
                .CreateLogger();
            builder.Logging.AddSerilog(logger);

            // Добавяне на услуги в DI контейнера:
            // Регистрираме конфигурациите (например за MongoDB), Data Layer и Business Layer
            builder.Services
                .AddConfigurations(builder.Configuration)
                .RegisterDataLayer()
                .RegisterBusinessLayer();

            // Конфигуриране на Mapster за мапиране между моделите
            MapsterConfiguration.Configure();
            builder.Services.AddMapster();

            // Регистриране на валидаторите (например за заявки към продукти)
            builder.Services
                .AddValidatorsFromAssemblyContaining<AddProductRequestValidator>()
                .AddFluentValidationAutoValidation();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Добавяне на HealthChecks (примерно, за проверка на специфични услуги)
            builder.Services.AddHealthChecks()
                .AddCheck<CustomHealthChecks>("Custom");

            var app = builder.Build();

            // Конфигурация на HTTP pipeline-а:
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Картиране на HealthChecks endpoint-а
            app.MapHealthChecks("/Sample");

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}

