namespace FactoryPattern;

public class ConcreteCreator : Creator
{
    public override PagamentoProduct FactoryMethod()
    {
        return new PagamentoCompraInternacionalCP();
    }
}