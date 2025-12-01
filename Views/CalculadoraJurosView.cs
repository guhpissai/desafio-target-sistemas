using DesafioTarget.Helpers;
using DesafioTarget.Models;
using DesafioTarget.Services;

namespace DesafioTarget.Views;

public static class CalculadoraJurosView
{
  public static void Load()
  {

    var multaRegra = new RegraMultaPadrao();
    var calculadora = new CalculadoraMulta(multaRegra);

    while (true)
    {
      Console.Clear();

      ConsoleHelper.DesenharHeader("CALCULAR JUROS");

      Console.WriteLine("");
      Console.WriteLine("Digite o valor: ");
      if (!decimal.TryParse(Console.ReadLine(), out var valor))
      {
        ConsoleHelper.MostrarErro("O valor deve ser um número valido");
        continue;
      }

      Console.Write("Digite a data de vencimento (Ex: 2020-05-11): ");

      if (!DateTime.TryParse(Console.ReadLine(), out var data))
      {
        ConsoleHelper.MostrarErro("Data informada inválida");
        continue;
      }

      var juros = calculadora.Calcular(valor, data);
      var totalAtualizado = valor + juros;
      Console.Clear();

      Console.WriteLine("===== RESULTADO =====");
      Console.WriteLine($"Data de hoje:          {DateTime.Today:dd/MM/yyyy}");
      Console.WriteLine($"Data de vencimento:     {data:dd/MM/yyyy}");

      Console.WriteLine();
      Console.WriteLine($"Valor original:         {valor:C}");
      Console.WriteLine($"Juros calculado:        {juros:C}");
      Console.WriteLine($"Valor atualizado:       {totalAtualizado:C}");

      Console.WriteLine();
      Console.WriteLine("Pressione qualquer tecla para continuar...");
      Console.ReadKey();
      Menu.Load();
    }
  }
};