using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class PagamentoCompraNacionalCP : PagamentoProduct
    {
        public PagamentoCompraNacionalCP()
        {
            Descricao = INTERNATIONAL_PURCHASE;
            Tipo = CREDIT_CARD_TYPE;
        }
        public override void Pagar(double valor)
        {
            Console.WriteLine($"A conta {Descricao} foi paga via {Tipo} no valor de $ {valor}.");
        }
    }
}
