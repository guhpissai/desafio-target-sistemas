using System.Text.Json.Serialization;

namespace DesafioTarget.Models;

public class Estoque
{
  [JsonPropertyName("estoque")]
  public List<Produto> Produtos { get; set; } = [];
}