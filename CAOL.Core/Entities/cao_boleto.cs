using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Entities
{
    public class cao_boleto
    {
        public int co_boleto { get; set; }
        public int co_cliente { get; set; }
        public int co_sistema { get; set; }
        public int co_os { get; set; }
        public string valor { get; set; }
        public string vencimento { get; set; }
        public int status { get; set; }
        public string boleto { get; set; }
        public string linha_dig { get; set; }
        public string parcela { get; set; }

    }
}
