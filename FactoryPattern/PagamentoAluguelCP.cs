namespace FactoryPattern;

//ConcreteProduct
public class PagamentoAluguelCP : PagamentoProduct
{
    public PagamentoAluguelCP()
    {
        this._descricao = "Aluguel";
        this._tipo = "Boleto";
    }
    public override void Pagar(double valor)
    {
        Console.WriteLine($"A conta {_descricao} foi paga via {_tipo} no valor de R$ {valor}.");
    }
}