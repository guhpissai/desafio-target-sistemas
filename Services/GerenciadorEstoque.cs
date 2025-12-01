using DesafioTarget.Helpers;
using DesafioTarget.Interfaces;
using DesafioTarget.Models;

namespace DesafioTarget.Services;

public class GerenciadorEstoque : IGerenciadorEstoque
{
  private Estoque _estoque;
  private List<Movimentacao> _movimentacoes;
  private readonly string estoquePath = "./Data/estoque.json";
  private readonly string movimentacoesPath = "./Data/movimentacoes.json";

  public GerenciadorEstoque(Estoque estoque, List<Movimentacao> movimentacoes)
  {
    _estoque = estoque;
    _movimentacoes = movimentacoes;
  }

  public Produto? Entrada(int id, int quantidade)
  {
    var produtoEncontrado = _estoque.Produtos.FirstOrDefault(p => p.Id == id);

    if (produtoEncontrado == null)
      return null;

    produtoEncontrado.Estoque += quantidade;


    _movimentacoes.Add(new Movimentacao()
    {
      Descricao = "Entrada",
      ProdutoId = produtoEncontrado.Id,
      Quantidade = quantidade,
      Data = DateTime.Now
    });

    var wrapper = new MovimentacoesWrapper { Movimentacoes = _movimentacoes };
    JsonHelper.SaveChanges(_estoque, estoquePath);
    JsonHelper.SaveChanges(wrapper, movimentacoesPath);

    return produtoEncontrado;
  }

  public Produto? Saida(int id, int quantidade)
  {
    var produtoEncontrado = _estoque.Produtos.FirstOrDefault(p => p.Id == id);

    if (produtoEncontrado == null)
      return null;

    if (produtoEncontrado.Estoque < quantidade)
      return null;

    produtoEncontrado.Estoque -= quantidade;

    _movimentacoes.Add(new Movimentacao()
    {
      Descricao = "Saída",
      ProdutoId = produtoEncontrado.Id,
      Quantidade = quantidade,
      Data = DateTime.Now
    });

    var wrapper = new MovimentacoesWrapper { Movimentacoes = _movimentacoes };
    JsonHelper.SaveChanges(_estoque, estoquePath);
    JsonHelper.SaveChanges(wrapper, movimentacoesPath);

    return produtoEncontrado;
  }
}