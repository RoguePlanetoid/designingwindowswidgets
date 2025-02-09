namespace Design.Widget.Library.Providers.Internal;

/// <summary>
/// Design Provider
/// </summary>
internal class DesignProvider : IDesignProvider
{
    private const string comma = ",";
    private const string invalid = "Invalid Json";

    /// <summary>
    /// Is Valid Json
    /// </summary>
    /// <param name="json">Json String</param>
    /// <returns>True if if, False if Not</returns>
    private static bool IsValidJson(string? json)
    {
        if (string.IsNullOrWhiteSpace(json))
            return false;
        try
        {
            using var document = JsonDocument.Parse(json);
            return document != null;
        }
        catch (JsonException)
        {
            return false;
        }
    }

    /// <summary>
    /// Is Valid Adaptive Card
    /// </summary>
    /// <param name="card">Card</param>
    /// <param name="message">Warning or Error Message</param>
    /// <returns>True if Is, False if Not</returns>
    private static bool IsValidAdaptiveCard(string? card, out string message)
    {
        try
        {
            if (IsValidJson(card))
            {
                message = string.Join(comma,
                AdaptiveCard.FromJson(card)
                .Warnings.Select(s => s.Message));
                return true;
            }
            else
            {
                message = invalid;
                return false;
            }
        }
        catch (AdaptiveSerializationException ex)
        {
            message = ex.Message;
            return false;
        }
    }

    /// <summary>
    /// Get Card Model
    /// </summary>
    /// <param name="template">Adaptive Card Template</param>
    /// <param name="data">Adaptive Card Data</param>
    /// <returns>Card Model</returns>
    public CardModel GetCardModel(string? template, string? data)
    {
        var model = new CardModel();
        var valid = IsValidAdaptiveCard(template, out var message);
        var success = valid && message.Equals(string.Empty);
        if(success)
        {
            model.Template = template;
        }
        else
        {
            model.Error = message;
        }
        model.Data = !string.IsNullOrWhiteSpace(data) &&
            IsValidJson(data) ? data : null;
        return model;
    }
}
