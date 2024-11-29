
using CommunityToolkit.Maui;
using Microsoft.AspNetCore.Components.WebView.Maui;
using SampleProject1.Data;
using SampleProject1.Services;
using SampleProject1.ViewModels;

namespace SampleProject1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>().ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			}).UseMauiCommunityToolkit();



      



        builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
		/*builder.Services.AddSingleton<WeatherForecastService>();*/

		AddServices(builder.Services);


        return builder.Build();
	}


	public static void AddServices(IServiceCollection services) 
	{
		services.AddSingleton<AppViewModel>()
				.AddSingleton<MauiInterop>()
				.AddSingleton<AppState>();

        services.AddSingleton<DatabaseContext>()
				.AddTransient<SeedDataService>();

		services.AddTransient<AuthService>();

    }

}
