using DesafioTarget.Helpers;
using DesafioTarget.Models;

namespace DesafioTarget.Services;

public class GerenciadorEstoque
{
  private Estoque _estoque;
  private List<Movimentacao> _movimentacoes;

  public GerenciadorEstoque(Estoque estoque, List<Movimentacao> movimentacoes)
  {
    _estoque = estoque;
    _movimentacoes = movimentacoes;
  }

  public int Entrada(int id, int quantidade)
  {
    var produtoEncontrado = _estoque.Produtos.FirstOrDefault(p => p.Id == id);

    if (produtoEncontrado != null)
    {
      Console.WriteLine($"{produtoEncontrado.Descricao} | {produtoEncontrado.Estoque}");
      produtoEncontrado.Estoque += quantidade;

      _movimentacoes.Add(new Movimentacao()
      {
        Descricao = TipoMovimentacao.Entrada,
      });

      JsonHelper.SaveChanges(_estoque);
      Console.WriteLine($"{produtoEncontrado.Descricao} | {produtoEncontrado.Estoque}");

      return produtoEncontrado.Estoque;
    }

    return 0;
  }

  public int Saida(int id, int quantidade)
  {
    var produtoEncontrado = _estoque.Produtos.FirstOrDefault(p => p.Id == id);

    if (produtoEncontrado != null)
    {
      produtoEncontrado.Estoque -= quantidade;

      _movimentacoes.Add(new Movimentacao()
      {
        Descricao = TipoMovimentacao.Saida,
      });

      JsonHelper.SaveChanges(_estoque);
      return produtoEncontrado.Estoque;
    }

    return 0;
  }


}