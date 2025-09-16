namespace FactoryPattern;

public abstract class PagamentoProduct
{
    protected string? Descricao { get; set; }
    protected string? Tipo { get; set; }

    protected readonly string INTERNATIONAL_PURCHASE = "Compra Internacional";
    protected readonly string NATIONAL_PURCHASE = "Compra Nacional";
    protected readonly string CREDIT_CARD_TYPE = "Cartão de Crédito";
    protected readonly string PIX_TYPE = "PIX";

    public abstract void Pagar(double valor);

}