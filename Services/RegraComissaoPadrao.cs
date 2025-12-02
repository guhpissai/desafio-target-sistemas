using DesafioTarget.Interfaces;
using DesafioTarget.Models;

namespace DesafioTarget.Services;

public class RegraComissaoPadrao : IRegraComissao
{
  private const decimal MetaAlta = 500M;
  private const decimal MetaBaixa = 100M;
  private const decimal PercentualAlto = 0.05M;
  private const decimal PercentualBaixo = 0.01M;
  public decimal Calcular(Venda venda)
  {
    if (venda.Valor >= MetaAlta)
      return Arredondar(venda.Valor * PercentualAlto);

    if (venda.Valor >= MetaBaixa)
      return Arredondar(venda.Valor * PercentualBaixo);

    return 0;
  }

  private static decimal Arredondar(decimal valor)
  {
    return Math.Round(valor, 2, MidpointRounding.AwayFromZero);
  }
}