using System.Text.Json;

namespace DesafioTarget.Helpers;

public static class JsonHelper
{
  private static readonly JsonSerializerOptions _options = new()
  {
    PropertyNameCaseInsensitive = true,
    WriteIndented = true
  };

  public static T Deserialize<T>(string path) where T : new()
  {
    if (!File.Exists(path))
      return new T();

    try
    {
      using FileStream stream = File.OpenRead(path);

      return JsonSerializer.Deserialize<T>(stream, _options) ?? new T();
    }
    catch (JsonException)
    {
      return new T();
    }
  }

  public static void SaveChanges<T>(T data, string path)
  {
    var directory = Path.GetDirectoryName(path);
    if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
      Directory.CreateDirectory(directory);

    using FileStream stream = File.Create(path);
    JsonSerializer.Serialize(stream, data, _options);
  }
}