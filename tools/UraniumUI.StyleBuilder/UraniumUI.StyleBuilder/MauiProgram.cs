﻿using CommunityToolkit.Maui;
using DotNurse.Injector;
using Mopups.Hosting;

namespace UraniumUI.StyleBuilder;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureMopups()
            .UseUraniumUI()
            .UseUraniumUIMaterial()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                fonts.AddMaterialIconFonts();
            });

        builder.Services.AddMopupsDialogs();

        var thisAssembly = typeof(MauiProgram).Assembly;

        builder.Services.AddServicesFrom(
            type => typeof(Page).IsAssignableFrom(type) || type.Name.EndsWith("ViewModel"),
            ServiceLifetime.Transient,
            options => options.Assembly = thisAssembly)
        .AddServicesByAttributes();

        return builder.Build();
    }
}
