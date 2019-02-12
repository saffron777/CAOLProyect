using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Entities
{
    public class cao_diary_report_consultor
    {
        public int co_diary_report_consultor { get; set; }
        public int co_movimento { get; set; }
        public int co_atividade { get; set; }
        public DateTime dt_agendamento { get; set; }
        public DateTime dt_agendamento_fim { get; set; }
        public float vl_fechamento { get; set; }
        public long co_cliente { get; set; }

    }
}
