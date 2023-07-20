using Microsoft.Extensions.DependencyInjection;
using MoneyTracker.Application.Interfaces;
using MoneyTracker.Application.Services;

namespace MoneyTracker.Infra.CrossCutting.IoC
{
    public class DependencyInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            AddAutoMapper(services);
            AddRepositories(services);
            AddServices(services);
        }
        
        private static void AddServices(IServiceCollection services)
        {
            services.AddTransient<ITransactionAppService, TransactionAppService>();
        }
        
        private static void AddRepositories(IServiceCollection services)
        {
            
        }
        
        private static void AddAutoMapper(IServiceCollection services)
        {
            
        }
    }
}