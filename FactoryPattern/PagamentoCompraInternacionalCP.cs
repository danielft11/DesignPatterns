namespace FactoryPattern;

//ConcreteProduct
public class PagamentoCompraInternacionalCP : PagamentoProduct
{
    public PagamentoCompraInternacionalCP()
    {
        Descricao = NATIONAL_PURCHASE;
        Tipo = PIX_TYPE;    
    }
    public override void Pagar(double valor)
    {
        Console.WriteLine($"A conta {Descricao} foi paga via {Tipo} no valor de $ {valor}.");
    }
}