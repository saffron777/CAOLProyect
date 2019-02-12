using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Entities
{
    public class cao_bonus_status
    {
        public int id { get; set; }
        public string co_usuario { get; set; }
        public DateTime data_solic { get; set; }
        public string mes { get; set; }
        public string valor { get; set; }
        public string is_solic { get; set; }
        public string is_pg { get; set; }
        public string is_horas { get; set; }

    }
}
