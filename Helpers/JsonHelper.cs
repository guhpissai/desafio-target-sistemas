using System.Text.Json;

namespace DesafioTarget.Helpers;

public static class JsonHelper
{
  public static T Deserialize<T>(string path)
  {
    var json = File.ReadAllText(path);

    var options = new JsonSerializerOptions
    {
      PropertyNameCaseInsensitive = true
    };

    return JsonSerializer.Deserialize<T>(json, options)!;
  }

}