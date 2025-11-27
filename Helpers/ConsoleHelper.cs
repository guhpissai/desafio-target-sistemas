namespace DesafioTarget.Helpers;

public static class ConsoleHelper
{
  public static void DesenharHeader(string title)
  {
    Console.ForegroundColor = ConsoleColor.Cyan;

    Console.WriteLine(new string('=', 40));

    int largura = 40;
    int padding = (largura - title.Length) / 2;
    padding = Math.Max(padding, 0);

    Console.WriteLine($"{new string(' ', padding)}{title}");
    Console.WriteLine(new string('=', 40));
    Console.WriteLine();

    Console.ResetColor();
  }
  public static void MostrarErro(string mensagem)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\n❌ {mensagem}");
    Console.ResetColor();

    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
  }

  public static void MostrarStatus(string mensagem)
  {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\n✔ {mensagem}");
    Console.ResetColor();
    Thread.Sleep(700);
  }
}