using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Extensions.Logging;

namespace MeuApp;

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
                fonts.AddFont("Montserrat-Regular.ttf", "MontserratRegular");
                fonts.AddFont("Montserrat-Bold.ttf", "MontserratBold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        // Verificação de plataforma no método correto
        LogPlataforma();

        return builder.Build();
    }

    private static void LogPlataforma()
    {
#if ANDROID
        Console.WriteLine("Rodando no Android!");
#elif IOS
        Console.WriteLine("Rodando no iOS!");
#endif
    }
}
