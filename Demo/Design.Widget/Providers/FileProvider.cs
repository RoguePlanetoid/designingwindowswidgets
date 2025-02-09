namespace Design.Widget.Providers;

/// <summary>
/// File Provider
/// </summary>
public class FileProvider
{
    private readonly StorageFolder folder = ApplicationData.Current.LocalFolder;
    private static readonly JsonSerializerOptions options = new()
    {
        Converters = { new JsonStringEnumConverter() }
    };

    /// <summary>
    /// From Json
    /// </summary>
    /// <typeparam name="TData">Data</typeparam>
    /// <param name="json">JSON</param>
    /// <returns>Data</returns>
    public TData? FromJson<TData>(string json) where TData : class
    {
        try
        {
            return string.IsNullOrEmpty(json) ? null : 
                JsonSerializer.Deserialize<TData>(json, options);
        }
        catch
        {
            return null;
        }
    }

    /// <summary>
    /// To Json
    /// </summary>
    /// <typeparam name="TData">Data</typeparam>
    /// <param name="data">Data</param>
    /// <returns>Data String</returns>
    public string ToJson<TData>(TData data) where TData : class
    {
        try
        {
            return JsonSerializer.Serialize(data, options);
        }
        catch
        {
            return string.Empty;
        }
    }

    /// <summary>
    /// Load
    /// </summary>
    /// <typeparam name="TFileData">File Data</typeparam>
    /// <param name="name">Filename</param>
    /// <returns>Loaded File Data</returns>
    public TFileData? Load<TFileData>(string name) where TFileData : class
    {
        try
        {
            var storageFileTask = folder.TryGetItemAsync(name).AsTask();
            storageFileTask.Wait();
            var storageFile = storageFileTask.Result;
            if (storageFile != null)
            {
                var readTextTask = FileIO.ReadTextAsync(storageFile as IStorageFile).AsTask();
                readTextTask.Wait();
                var fileData = readTextTask.Result;
                return FromJson<TFileData>(fileData);
            }
            return default;
        }
        catch
        {
            return default;
        }
    }

    /// <summary>
    /// Save
    /// </summary>
    /// <typeparam name="TFileData">File Data</typeparam>
    /// <param name="name">File Name</param>
    /// <param name="fileData">File Data</param>    
    /// <returns>True on Success, False if Not</returns>
    public bool Save<TFileData>(string name, TFileData fileData) where TFileData : class
    {
        try
        {
            var content = ToJson(fileData);
            var createTask = folder.CreateFileAsync(name, CreationCollisionOption.ReplaceExisting).AsTask();
            createTask.Wait();
            var file = createTask.Result;
            var writeTextTask = FileIO.WriteTextAsync(file, content).AsTask();
            writeTextTask.Wait();
            return true;
        }
        catch
        {
            return false;
        }
    }
}
