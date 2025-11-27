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

    Console.WriteLine("===================================");
    Console.WriteLine("         GERENCIAR ESTOQUE         ");
    Console.WriteLine("===================================");

    Console.WriteLine("");
    Console.WriteLine("Selecione uma das opções: ");

    Console.WriteLine("[1] - Adicionar Produtos");
    Console.WriteLine("[2] - Remover Produtos");

    if (!short.TryParse(Console.ReadLine(), out var option))
      Console.WriteLine("Opção inválida!");


    switch (option)
    {
      case 1:
        var produtoEntrada = ProdutoInfo();
        gerenciadorEstoque.Entrada(produtoEntrada.id, produtoEntrada.qtd);
        break;
      case 2:
        var produtoSaida = ProdutoInfo();
        gerenciadorEstoque.Saida(produtoSaida.id, produtoSaida.qtd);
        break;
      default:
        Console.WriteLine("Opção inválida!");
        break;
    }


  }

  public static (int id, int qtd) ProdutoInfo()
  {
    Console.WriteLine("Digite o Id do produto:");
    if (!int.TryParse(Console.ReadLine(), out var id))
      Console.WriteLine("Id não encontrado");

    Console.WriteLine("Digite a quantidade: ");
    if (!int.TryParse(Console.ReadLine(), out var qtd))
      Console.WriteLine("A quantidade deve ser um número válido");

    return (id, qtd);
  }
}