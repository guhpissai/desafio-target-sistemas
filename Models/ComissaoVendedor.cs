namespace DesafioTarget.Models;

public class ComissaoVendedor
{
  public string Vendedor { get; set; } = string.Empty;
  public decimal TotalComissao { get; set; }

  public override string ToString()
  {
    return $"Nome: {Vendedor.PadRight(16)} | Comissão: R$ {TotalComissao:0.00}";
  }
}