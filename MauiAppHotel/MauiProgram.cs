using Microsoft.Extensions.Logging;

namespace MauiAppHotel
{
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
                    fonts.AddFont("Anton-Regular.ttf", "AntonRegular");
                    fonts.AddFont("Codystar-Regular.ttf", "CodystarRegular");
                    fonts.AddFont("ComicRelief-Regular.ttf", "ComicReliefRegular");
                    fonts.AddFont("DancingScript-Regular.ttf", "DancingScriptRegular");
                    fonts.AddFont("AlfaSlabOne-Regular.ttf", "AlfaSlabOneRegular");
                }); 

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
