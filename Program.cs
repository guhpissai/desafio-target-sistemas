using DesafioTarget.Models;
using DesafioTarget.Services;
using DesafioTarget.Helpers;

var vendas = JsonHelper.Deserialize<VendasWrapper>("./Data/vendas.json");
var estoque = JsonHelper.Deserialize<Estoque>("./Data/estoque.json");

// Services
var regra = new RegraComissaoPadrao();
var calculaComissao = new CalculadoraComissao(regra);
var movimentacoes = new List<Movimentacao>();
var gerenciadorEstoque = new GerenciadorEstoque(estoque, movimentacoes);


Console.WriteLine("Gerenciar Estoque");

Console.WriteLine("O que deseja fazer?");
Console.WriteLine("[1] - Adicionar Produtos");
Console.WriteLine("[2] - Remover Produtos");

int.TryParse(Console.ReadLine(), out var option);


switch (option)
{
  case 1:
    Console.WriteLine("Digite o Id do Produto: ");
    int.TryParse(Console.ReadLine(), out var id);
    Console.WriteLine("Digite a quantidade");
    int.TryParse(Console.ReadLine(), out var quantidade);
    gerenciadorEstoque.Saida(id, quantidade);
    break;
  default:
    Console.WriteLine("Opcão inválida");
    break;
}





