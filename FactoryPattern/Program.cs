using FactoryPattern;

/* Código antigo com alto acoplamento
 
var compra = new PagamentoProduct
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

compra.Pagar();
pagamentoCompraInternacional.Pagar();

*/

Creator creator = new ConcreteCreator();

var compraInternacional = creator.FactoryMethodCompraInternacional();
compraInternacional.Pagar(2000);

var compraNacional = creator.FactoryMethodCompraNacional();
compraNacional.Pagar(1500);

