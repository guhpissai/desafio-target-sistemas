using DesafioTarget.Models;
using DesafioTarget.Services;
using DesafioTarget.Helpers;

var wrapper = JsonHelper.Deserialize<VendasWrapper>("./Data/vendas.json");

var regra = new RegraComissaoPadrao();
var calculaComissao = new CalculadoraComissao(regra);

if (wrapper?.Vendas is not null)
{
  var comissoes = calculaComissao.Calcular(wrapper.Vendas);

  foreach (var comissao in comissoes)
  {
    Console.WriteLine(comissao.ToString());
  }
}






