namespace DesafioTarget.Models;

public class Movimentacao
{
  private static int contador = 0;
  public int Id { get; set; }
  public TipoMovimentacao Descricao { get; set; }

  public Movimentacao()
  {
    contador++;
    Id = contador;
  }
}

public enum TipoMovimentacao
{
  Entrada,
  Saida
}