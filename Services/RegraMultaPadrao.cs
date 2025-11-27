using DesafioTarget.Interfaces;

namespace DesafioTarget.Services;

public class RegraMultaPadrao : IRegraMulta
{
  private const decimal Juros = 0.025M;
  public decimal Calcular(decimal valor, DateTime data)
  {
    var diasAtraso = (DateTime.Today - data).Days;

    if (diasAtraso < 0)
      diasAtraso = 0;

    return Juros * valor * diasAtraso;
  }
}