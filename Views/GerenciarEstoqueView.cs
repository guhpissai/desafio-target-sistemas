using DesafioTarget.Helpers;
using DesafioTarget.Models;
using DesafioTarget.Services;

namespace DesafioTarget.Views;

public static class GerenciadorEstoqueView
{
  public static void Load()
  {

    var estoque = JsonHelper.Deserialize<Estoque>("./Data/estoque.json");
    var movimentacoes = new List<Movimentacao>();
    var gerenciadorEstoque = new GerenciadorEstoque(estoque, movimentacoes);

    while (true)
    {
      Console.Clear();

      ConsoleHelper.DesenharHeader("GERENCIAR ESTOQUE");

      Console.WriteLine("");
      Console.WriteLine("Selecione uma das opções: ");

      Console.WriteLine("[1] - Adicionar Produtos");
      Console.WriteLine("[2] - Remover Produtos");
      Console.WriteLine("");
      Console.WriteLine("[V] - Voltar");
      Console.WriteLine("[0] - Encerrar");

      var option = Console.ReadLine();

      switch (option)
      {
        case "1":
          var entrada = ProdutoInfo();
          var prdEntrada = gerenciadorEstoque.Entrada(entrada.id, entrada.qtd);

          if (prdEntrada == null)
          {
            ConsoleHelper.MostrarErro("Produto não encontrado");
            continue;
          }

          Console.WriteLine($"Id: {prdEntrada.Id} - Novo estoque: {prdEntrada.Estoque}");
          Console.ReadKey();
          break;
        case "2":
          var saida = ProdutoInfo();
          var prdSaida = gerenciadorEstoque.Saida(saida.id, saida.qtd);

          if (prdSaida == null)
          {
            ConsoleHelper.MostrarErro("Produto não encontrado");
            continue;
          }

          Console.WriteLine($"Id: {prdSaida.Id} - Novo estoque: {prdSaida.Estoque}");
          Console.ReadKey();
          break;
        case "v" or "V":
          return;
        case "0":
          Environment.Exit(0);
          break;
        default:
          ConsoleHelper.MostrarErro("Entrada inválida! Digite apenas números.");
          break;
      }
    }
  }

  private static (int id, int qtd) ProdutoInfo()
  {
    int id;
    int qtd;

    while (true)
    {
      Console.WriteLine("Digite o Id do produto:");
      if (int.TryParse(Console.ReadLine(), out id))
        break;

      ConsoleHelper.MostrarErro("ID inválido! Digite um número inteiro.");
    }

    while (true)
    {
      Console.WriteLine("Digite a quantidade:");
      if (int.TryParse(Console.ReadLine(), out qtd))
        break;

      ConsoleHelper.MostrarErro("Quantidade inválida! Digite apenas números inteiros.");
    }

    return (id, qtd);
  }
}