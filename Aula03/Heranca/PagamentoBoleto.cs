﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    class PagamentoBoleto : Pagamento
    {
        public string LinhaDigitavel { get; set; }
        public override double ValorASerPago { get => ValorPago; }
    }
}
