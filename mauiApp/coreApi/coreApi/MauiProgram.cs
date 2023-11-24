using coreApi.DataServices;
using Microsoft.Extensions.Logging;


namespace coreApi;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		//builder.Services.AddHttpClient("api",http => http.BaseAddress = new Uri("https://localhost:7001/api/employee"));
		builder.Services.AddSingleton<IRestDataService, RestDataService>();
		builder.Services.AddSingleton<MainPage>();

		return builder.Build();
	}
}

