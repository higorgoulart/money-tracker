using MoneyTracker.Infra.CrossCutting.IoC;

namespace MoneyTracker.Configuration
{
    public static class IoC
    {
        private static ServiceProvider _serviceProvider;

        public static T GetInstance<T>() where T : class
        {
            return _serviceProvider.GetRequiredService<T>();
        }

        public static void Init()
        {
            var services = new ServiceCollection();
            
            DependencyInjector.RegisterServices(services);
            
            _serviceProvider = services.BuildServiceProvider();
        }
    }
}