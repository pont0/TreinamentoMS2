using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    abstract class Pagamento
    {
        public DateTime  DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public abstract double ValorASerPago { get; }
        public double ValorPago { get; set; }
    }
}
