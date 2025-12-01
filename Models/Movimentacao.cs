
namespace DesafioTarget.Models;

public class Movimentacao
{

  public Guid Id { get; set; } = Guid.NewGuid();
  public string Descricao { get; set; } = string.Empty;
  public int Quantidade { get; set; }
  public DateTime Data { get; set; }
  public int ProdutoId { get; set; }

}