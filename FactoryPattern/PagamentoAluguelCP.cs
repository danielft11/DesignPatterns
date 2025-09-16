namespace FactoryPattern;

//ConcreteProduct
public class PagamentoAluguelCP : PagamentoProduct
{
    public PagamentoAluguelCP()
    {
        this.Descricao = "Aluguel";
        this.Tipo = "Boleto";
    }
    public override void Pagar(double valor)
    {
        Console.WriteLine($"A conta {Descricao} foi paga via {Tipo} no valor de R$ {valor}.");
    }
}