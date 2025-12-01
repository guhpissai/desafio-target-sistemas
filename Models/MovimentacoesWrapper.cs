using System.Text.Json.Serialization;

namespace DesafioTarget.Models;

public class MovimentacoesWrapper
{
  [JsonPropertyName("movimentacoes")]
  public List<Movimentacao> Movimentacoes { get; set; } = [];
}