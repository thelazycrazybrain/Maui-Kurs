using Microsoft.Extensions.Logging;
using ServiceApp.Pages;
using ServiceApp.Services;
using ServiceApp.ViewModels;

namespace ServiceApp {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            // ...
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services
                .AddSingleton<FoodViewModel>()
                .AddSingleton<FoodPage>()
                .AddSingleton<IDeviceService, DeviceService>()
                .AddSingleton<IFoodService, FoodService>() ;
#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
