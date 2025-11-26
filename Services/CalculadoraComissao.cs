using DesafioTarget.Interfaces;
using DesafioTarget.Models;

namespace DesafioTarget.Services;

public class CalculadoraComissao
{
  private readonly IRegraComissao _regraComissao;

  public CalculadoraComissao(IRegraComissao regraComissao)
  {
    _regraComissao = regraComissao;
  }

  public List<ComissaoVendedor> Calcular(List<Venda> vendas)
  {
    var resultado = vendas
    .Select(v => new
    {
      v.Vendedor,
      Comissao = _regraComissao.Calcular(v)
    })
    .GroupBy(g => g.Vendedor)
    .Select(x => new ComissaoVendedor
    {
      Vendedor = x.Key,
      TotalComissao = x.Sum(x => x.Comissao)
    }).ToList();

    return resultado;
  }
}