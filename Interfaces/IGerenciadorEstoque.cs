using DesafioTarget.Models;

namespace DesafioTarget.Interfaces;

public interface IGerenciadorEstoque
{
  public Produto? Entrada(int id, int quantidade);
  public Produto? Saida(int id, int quantidade);
}