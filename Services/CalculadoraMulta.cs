using DesafioTarget.Interfaces;

namespace DesafioTarget.Services;

public class CalculadoraMulta
{
  private readonly IRegraMulta _regraMulta;
  public CalculadoraMulta(IRegraMulta regraMulta)
  {
    _regraMulta = regraMulta;
  }

  public decimal Calcular(decimal valor, DateTime data)
  {
    return _regraMulta.Calcular(valor, data);
  }
}