namespace DesafioTarget.Models;

public class Movimentacao
{
  private static int contador = 0;
  public int Id { get; set; }
  public string Descricao { get; set; } = string.Empty;
  public Movimentacao()
  {
    contador++;
    Id = contador;
  }
}