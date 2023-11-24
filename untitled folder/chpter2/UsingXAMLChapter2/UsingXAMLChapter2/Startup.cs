using System;
using UsingXAMLChapter2.Services;

namespace UsingXAMLChapter2
{
	public static class Startup
	{
		public static IServiceProvider ServiceProvider { get; set; }
		public static IServiceProvider Init()
		{
			var serviceProvider = new ServiceCollection()
				//.AddSingleton<IService>()
				//using configurationService to adding all
				//injected services from DependencyInjectionCollecion.
				.ConfigureServices()
				.ConfigureViewsModel()

				.BuildServiceProvider();
			ServiceProvider = serviceProvider;
			return serviceProvider;
		}
	}


	public static class DependencyInjectionContainer
	{
		//injectd classes in serviceCollection...
		public static IServiceCollection ConfigureServices(this
			IServiceCollection services)
		{
			services.AddSingleton<IService, Service>();
			return services;
		}

        public static IServiceCollection ConfigureViewsModel(this
            IServiceCollection services)
        {
            services.AddSingleton<MainPageModel>();
            return services;
        }
    }


    public class MainPageModel
	{
		public string InjectedString { get; set; }
		public MainPageModel(IService myService)
		{
			InjectedString = myService.GetStr();
		}
	}
}

