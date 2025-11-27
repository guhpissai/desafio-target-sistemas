using DesafioTarget.Interfaces;

namespace DesafioTarget.Services;

public class CalculadoraMulta
{
  public IRegraMulta _regraMulta { get; set; }
  public CalculadoraMulta(IRegraMulta regraMulta)
  {
    _regraMulta = regraMulta;
  }

  public decimal Calcular(decimal valor, DateTime data)
  {
    return _regraMulta.Calcular(valor, data);
  }
}