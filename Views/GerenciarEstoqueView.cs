using DesafioTarget.Helpers;
using DesafioTarget.Models;
using DesafioTarget.Services;

namespace DesafioTarget.Views;

public static class GerenciadorEstoqueView
{
  public static void Load()
  {

    var estoque = JsonHelper.Deserialize<Estoque>("./Data/estoque.json");
    var wrapper = JsonHelper.Deserialize<MovimentacoesWrapper>("./Data/movimentacoes.json");
    var movimentacoes = wrapper?.Movimentacoes ?? new List<Movimentacao>();
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
      Console.WriteLine("[0] - Voltar");

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

          SaidaConsole(prdEntrada.Id, prdEntrada.Estoque);
          break;
        case "2":
          var (id, qtd) = ProdutoInfo();
          var prdSaida = gerenciadorEstoque.Saida(id, qtd);

          if (prdSaida == null)
          {
            ConsoleHelper.MostrarErro("Produto não encontrado");
            continue;
          }

          SaidaConsole(prdSaida.Id, prdSaida.Estoque);
          break;
        case "0":
          return;
        default:
          ConsoleHelper.MostrarErro("Entrada inválida! Digite apenas números.");
          break;
      }
    }
  }

  private static (int id, int qtd) ProdutoInfo()
  {
    Console.Clear();

    ConsoleHelper.DesenharHeader("GERENCIAR ESTOQUE");

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

  private static void SaidaConsole(int prdId, int prdEstoque)
  {
    Console.WriteLine("");
    Console.WriteLine($"Id: {prdId} - Novo estoque: {prdEstoque}");
    Console.WriteLine("");
    Console.WriteLine("Aperte ENTER para voltar...");
    Console.ReadKey();
  }
}