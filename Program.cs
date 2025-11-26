using System.Text.Json;
using DesafioTarget.Models;

var json = File.ReadAllText("./Utils/vendas.json");

var options = new JsonSerializerOptions
{
  PropertyNameCaseInsensitive = true
};

var wrapper = JsonSerializer.Deserialize<VendasWrapper>(json, options);

if (wrapper?.Vendas is not null)
{
  Comissao.CalculaComissao(wrapper.Vendas);
}






