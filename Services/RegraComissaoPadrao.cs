using DesafioTarget.Interfaces;
using DesafioTarget.Models;

namespace DesafioTarget.Services;

public class RegraComissaoPadrao : IRegraComissao
{
  public decimal Calcular(Venda venda)
  {
    decimal comissao = 0;

    if (venda.Valor >= 500)
      comissao = venda.Valor * 0.05M;
    else if (venda.Valor >= 100)
      comissao = venda.Valor * 0.01M;

    return Math.Round(comissao, 2, MidpointRounding.AwayFromZero);
  }
}