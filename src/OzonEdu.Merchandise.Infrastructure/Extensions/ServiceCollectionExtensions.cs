using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OzonEdu.Merchandise.Infrastructure.Handlers.CreateMerchRequest;

namespace OzonEdu.Merchandise.Infrastructure.Extensions
{
    /// <summary>
    /// Класс расширений для типа <see cref="IServiceCollection"/> для регистрации инфраструктурных сервисов
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Добавление в DI контейнер инфраструктурных сервисов
        /// </summary>
        /// <param name="services">Объект IServiceCollection</param>
        /// <returns>Объект <see cref="IServiceCollection"/></returns>
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateMerchRequestCommandHandler).Assembly);
            
            return services;
        }
        
        /// <summary>
        /// Добавление в DI контейнер инфраструктурных репозиториев
        /// </summary>
        /// <param name="services">Объект IServiceCollection</param>
        /// <returns>Объект <see cref="IServiceCollection"/></returns>
        public static IServiceCollection AddInfrastructureRepositories(this IServiceCollection services)
        {
            return services;
        }
    }
}