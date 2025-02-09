namespace Design.Widget.Library.Providers;

/// <summary>
/// Design Provider
/// </summary>
public interface IDesignProvider
{
    /// <summary>
    /// Get Card Model
    /// </summary>
    /// <param name="template">Adaptive Card Template</param>
    /// <param name="data">Adaptive Card Data</param>
    /// <returns>Card Model</returns>
    CardModel GetCardModel(string? template, string? data);
}
