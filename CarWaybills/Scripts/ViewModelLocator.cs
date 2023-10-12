using CarWaybills.Scripts.Services;
using CarWaybills.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace CarWaybills.Scripts
{
    public class ViewModelLocator
    {
        private static ServiceProvider _provider;

        public static void Init()
        {
            var services = new ServiceCollection();

            services.AddTransient<MainViewModel>();
            services.AddTransient<CarViewModel>();
            services.AddTransient<WaybillViewModel>();

            services.AddSingleton<PageService>();
            services.AddSingleton<EventBus>();
            services.AddSingleton<MessageBus>();



            _provider = services.BuildServiceProvider();

            foreach (var item in services)
            {
                _provider.GetRequiredService(item.ServiceType);
            }
        }

        public MainViewModel MainViewModel => _provider.GetRequiredService<MainViewModel>();
        public CarViewModel CarViewModel => _provider.GetRequiredService<CarViewModel>();
        public WaybillViewModel WaybillViewModel => _provider.GetRequiredService<WaybillViewModel>();
    }
}
