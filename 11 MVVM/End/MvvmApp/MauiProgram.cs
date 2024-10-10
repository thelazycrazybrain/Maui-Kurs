using Microsoft.Extensions.Logging;
using MvvmApp.Pages;
using MvvmApp.ViewModels;

namespace MvvmApp {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services
                .AddSingleton<TodoListViewModel>()
                .AddTransient<TodoDetailViewModel>()
                .AddSingleton<TodoListPage>()
                .AddTransient<TodoDetailPage>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
