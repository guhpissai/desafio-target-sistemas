using DesafioTarget.Helpers;
using DesafioTarget.Models;
using DesafioTarget.Services;

namespace DesafioTarget.Views;

public static class CalculadoraComissaoView
{
  public static void Load()
  {
    Console.Clear();
    Console.WriteLine("===================================");
    Console.WriteLine("       COMISSÃO POR VENDEDOR       ");
    Console.WriteLine("===================================");
    Console.WriteLine("");
    var regra = new RegraComissaoPadrao();
    var vendasWrapper = JsonHelper.Deserialize<VendasWrapper>("./Data/vendas.json");
    var calculaComissao = new CalculadoraComissao(regra);

    var comissoes = calculaComissao.Calcular(vendasWrapper.Vendas);

    foreach (var comissao in comissoes)
    {
      Console.WriteLine($"Vendedor: {comissao.Vendedor,-20} | Comissão: {comissao.TotalComissao:0.00}");
    }

    Console.WriteLine("");
    Console.WriteLine("Aperte ENTER para voltar...");
    Console.ReadKey();

    Console.Clear();
    Menu.Load();
  }
}