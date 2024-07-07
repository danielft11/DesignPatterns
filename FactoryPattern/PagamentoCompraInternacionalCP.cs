namespace FactoryPattern;

//ConcreteProduct
public class PagamentoCompraInternacionalCP : PagamentoProduct
{
    public PagamentoCompraInternacionalCP()
    {
        this._descricao = "Compra Internacional";
        this._tipo = "Cartão de Crédito";    
    }
    public override void Pagar(double valor)
    {
        Console.WriteLine($"A conta {_descricao} foi paga via {_tipo} no valor de $ {valor}.");
    }
}