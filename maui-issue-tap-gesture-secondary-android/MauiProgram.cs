﻿using Microsoft.Extensions.Logging;

namespace maui_issue_tap_gesture_secondary_android
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
        });

#if DEBUG
		builder.Logging.AddDebug();
#endif

      return builder.Build();
    }
  }
}