using FactoryPattern;

/* Código antigo com alto acoplamento
 
var pagamento = new PagamentoProduct
{
  Descricao = "Aluguel",
  Tipo = "Boleto",
  Valor = 1500
};

var pagamentoCompraInternacional = new PagamentoProduct
{
  Descricao = "Compra internacional",
  Tipo = "Cartão de Crédito",
  Valor = 250
};

pagamento.Pagar();
pagamentoCompraInternacional.Pagar();

*/

Creator creator = new ConcreteCreator();

var pagamento = creator.FactoryMethod();

pagamento.Pagar(2000);

