using System.Text.Json;
using DesafioTarget.Models;

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

  public static void SaveChanges(Estoque estoque)
  {
    File.WriteAllText("./Data/estoque.json", JsonSerializer.Serialize(estoque, new JsonSerializerOptions { WriteIndented = true }));
  }
}