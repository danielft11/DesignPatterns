namespace FactoryPattern;

public class ConcreteCreator : Creator
{
    public override PagamentoProduct FactoryMethodCompraInternacional()
    {
        return new PagamentoCompraInternacionalCP();
    }

    public override PagamentoProduct FactoryMethodCompraNacional()
    {
        return new PagamentoCompraNacionalCP();
    }
}