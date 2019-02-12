using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Entities
{
    public class cao_custo
    {
        public long co_custo { get; set; }
        public byte co_tipo_custo { get; set; }
        public string descricao { get; set; }
        public byte co_escritorio { get; set; }
        public DateTime dt_compra { get; set; }
        public DateTime dt_pagamento { get; set; }
        public string co_boleto { get; set; }
        public float valor { get; set; }
        public string parcela { get; set; }
        public byte pag { get; set; }
        public long co_custo_high { get; set; }

    }
}
