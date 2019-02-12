using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Entities
{
    public class cao_banco_de_horas
    {
        public int id { get; set; }
        public string co_usuario { get; set; }
        public DateTime data_cadastro { get; set; }
        public int segundos { get; set; }
        public string tipo { get; set; }

    }
}
