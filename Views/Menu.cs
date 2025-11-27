using DesafioTarget.Helpers;
using DesafioTarget.Services;

namespace DesafioTarget.Views;

public static class Menu
{
  public static void Load()
  {
    while (true)
    {
      Console.Clear();
      ConsoleHelper.DesenharHeader("DESAFIO TARGET");

      Console.WriteLine("Escolha uma opção abaixo:\n");
      Console.WriteLine("  [1]  Calcular Comissão");
      Console.WriteLine("  [2]  Gerenciar Estoque");
      Console.WriteLine("  [3]  Calcular Juros");
      Console.WriteLine("  [0]  Sair\n");

      Console.Write(" ➤ Sua escolha: ");

      if (!int.TryParse(Console.ReadLine(), out var option))
      {
        ConsoleHelper.MostrarErro("Entrada inválida! Digite apenas números.");
        continue;
      }

      switch (option)
      {
        case 1:
          ConsoleHelper.MostrarStatus("Abrindo Calculadora de Comissão...");
          CalculadoraComissaoView.Load();
          break;

        case 2:
          ConsoleHelper.MostrarStatus("Abrindo Gerenciador de Estoque...");
          GerenciadorEstoqueView.Load();
          break;

        case 3:
          ConsoleHelper.MostrarStatus("Abrindo Calculadora de Juros...");
          // Chamar a view correspondente aqui
          break;

        case 0:
          ConsoleHelper.MostrarStatus("Encerrando aplicação...");
          return;

        default:
          ConsoleHelper.MostrarErro("Opção inexistente! Escolha uma opção válida.");
          break;
      }
    }
  }
}
