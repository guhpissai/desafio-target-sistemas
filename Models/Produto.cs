using System.Text.Json.Serialization;

namespace DesafioTarget.Models;

public class Produto
{
  [JsonPropertyName("codigoProduto")]
  public int Id { get; set; }
  [JsonPropertyName("descricaoProduto")]
  public string Descricao { get; set; } = string.Empty;
  [JsonPropertyName("estoque")]
  public int Estoque { get; set; }
}