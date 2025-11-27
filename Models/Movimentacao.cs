
namespace DesafioTarget.Models;

public class Movimentacao
{
  private static int contador = 0;
  public int Id { get; set; }
  public string Descricao { get; set; } = string.Empty;
  public string Quantidade { get; internal set; }
  public DateTime Data { get; internal set; }
  public int ProdutoId { get; internal set; }

  public Movimentacao()
  {
    contador++;
    Id = contador;
  }
}