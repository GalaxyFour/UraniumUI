﻿using UraniumUI.Material.Controls;
using UraniumUI.Material.Extensions;
using UraniumUI.Material.Handlers;

namespace UraniumUI;
public static class UraniumUIMaterialMauiProgramExtensions
{
    public static MauiAppBuilder UseUraniumUIMaterial(this MauiAppBuilder builder)
    {
        builder.ConfigureMauiHandlers(handlers =>
        {
            handlers.AddHandler(typeof(ButtonView), typeof(ButtonViewHandler));
        });

        builder.ConfigureAutoFormViewForMaterial();

        return builder;
    }
}
