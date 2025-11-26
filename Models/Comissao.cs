namespace DesafioTarget.Models;

public static class Comissao
{
  public static void CalculaComissao(List<Venda> vendas)
  {
    var comissao = new Dictionary<string, double>();
    foreach (var venda in vendas)
    {
      if (!comissao.ContainsKey(venda.Vendedor))
        comissao[venda.Vendedor] = 0;

      if (venda.Valor >= 100.0 && venda.Valor < 500.0) comissao[venda.Vendedor] += venda.Valor * 0.01;
      if (venda.Valor >= 500) comissao[venda.Vendedor] += venda.Valor * 0.05;
    }

    foreach (var c in comissao)
    {
      Console.WriteLine($"Nome: {c.Key.PadRight(16)} | Comissão: R$ {double.Round(c.Value, 2)}");
    }
  }
}