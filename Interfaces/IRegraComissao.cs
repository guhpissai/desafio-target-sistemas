using DesafioTarget.Models;

namespace DesafioTarget.Interfaces;

public interface IRegraComissao
{
  decimal Calcular(Venda venda);
}