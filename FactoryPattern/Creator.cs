namespace FactoryPattern;

public abstract class Creator
{
    public abstract PagamentoProduct FactoryMethodCompraInternacional();
    public abstract PagamentoProduct FactoryMethodCompraNacional();
}