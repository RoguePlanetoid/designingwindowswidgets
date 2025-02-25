﻿namespace Design.Widget.Library;

/// <summary>
/// Extensions
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Add Library
    /// </summary>
    /// <param name="services">Service Collection</param>
    /// <returns>Service Collection</returns>
    public static IServiceCollection AddLibrary(this IServiceCollection services) =>
        services.AddSingleton<IDesignProvider, DesignProvider>();
}
