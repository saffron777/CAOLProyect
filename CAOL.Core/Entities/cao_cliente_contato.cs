using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Entities
{
    public class cao_cliente_contato
    {
        public int co_cliente { get; set; }
        public DateTime dt_contato { get; set; }
        public int fg_agendado { get; set; }
        public TimeSpan hr_ini { get; set; }
        public TimeSpan hr_end { get; set; }

    }
}
