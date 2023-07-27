using System.Configuration;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoneyTracker.Application.Interfaces;
using MoneyTracker.Application.Services;
using MoneyTracker.Domain.Interfaces;
using MoneyTracker.Infra.Data.Contexts;
using MoneyTracker.Infra.Data.Repositories;

namespace MoneyTracker.Infra.CrossCutting.IoC
{
    public class DependencyInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            AddAutoMapper(services);
            AddContext(services);
            AddRepositories(services);
            AddServices(services);
        }

        private static void AddAutoMapper(IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            var mapper = mapperConfig.CreateMapper();
            
            services.AddSingleton(mapper);
        }
        
        private static void AddContext(IServiceCollection services)
        {
            var connection = ConfigurationManager.ConnectionStrings["SQLite"];
            
            services.AddDbContext<MoneyTrackerContext>(options =>
                options.UseSqlite(connection.ToString())
            );
        }
        
        private static void AddRepositories(IServiceCollection services)
        {
            services.AddTransient<ITransactionRepository, TransactionRepository>();   
            services.AddTransient<ICategoryRepository, CategoryRepository>();   
        }
        
        private static void AddServices(IServiceCollection services)
        {
            services.AddTransient<ITransactionAppService, TransactionAppService>();
            services.AddTransient<ICategoryAppService, CategoryAppService>();
        }
    }
}