using DesafioTarget.Services;

namespace DesafioTarget.Views;

public static class Menu
{
  public static void Load()
  {
    Console.WriteLine("DESAFIO TARGET");
    Console.WriteLine("");
    Console.WriteLine("Escolha o programa: ");

    Console.WriteLine("[1] - Calcular Comissão");
    Console.WriteLine("[2] - Gerenciar Estoque");
    Console.WriteLine("[3] - Calcular Juros");

    if (!int.TryParse(Console.ReadLine(), out var option))
      Console.WriteLine("Opção inválida!");

    switch (option)
    {
      case 1:
        CalculadoraComissaoView.Load();
        break;
      case 2:
        GerenciadorEstoqueView.Load();
        break;
      default:
        Console.WriteLine("Opção Inválida");
        break;
    }
  }
}