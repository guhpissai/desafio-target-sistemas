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
        var produtoEntrada = ProdutoInfo();
        gerenciadorEstoque.Entrada(produtoEntrada.id, produtoEntrada.qtd);
        break;
      case "2":
        var produtoSaida = ProdutoInfo();
        gerenciadorEstoque.Saida(produtoSaida.id, produtoSaida.qtd);
        break;
      case "v":
        Menu.Load();
        break;
      case "0":
        ConsoleHelper.MostrarStatus("Encerrando...");
        Console.Clear();
        Environment.Exit(0);
        break;
      default:
        ConsoleHelper.MostrarErro("Entrada inválida! Digite apenas números.");
        Load();
        break;
    }
  }

  private static (int id, int qtd) ProdutoInfo()
  {
    Console.WriteLine("Digite o Id do produto:");
    if (!int.TryParse(Console.ReadLine(), out var id))
      ConsoleHelper.MostrarErro("Produto não encontrado! Verifique o ID informado.");

    Console.WriteLine("Digite a quantidade: ");
    if (!int.TryParse(Console.ReadLine(), out var qtd))
      Console.WriteLine("Quantidade inválida! Digite apenas números inteiros.");

    return (id, qtd);
  }
}