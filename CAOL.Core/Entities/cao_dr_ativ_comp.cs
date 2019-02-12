using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Entities
{
    public class cao_dr_ativ_comp
    {
        public int id_ativ_comp { get; set; }
        public string co_usuario { get; set; }
        public DateTime data { get; set; }
        public string assunto { get; set; }
        public TimeSpan tempo_gasto { get; set; }

    }
}
