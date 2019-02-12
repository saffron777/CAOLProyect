using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Entities
{
    public class cao_banco_horas
    {
        public int co_banc_horas { get; set; }
        public string co_usuario { get; set; }
        public string periodo { get; set; }
        public int min_mes { get; set; }
        public int min_ferias { get; set; }
        public int min_pago { get; set; }
        public int min_total { get; set; }

    }
}
