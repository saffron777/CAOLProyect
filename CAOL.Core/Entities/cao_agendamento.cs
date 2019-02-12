using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Entities
{
    public class cao_agendamento
    {
        public int co_agendamento { get; set; }
        public DateTime dt_hr_inicio { get; set; }
        public DateTime dt_hr_fim { get; set; }
        public int co_status_agendamento { get; set; }
        public int co_diary_report_consultor { get; set; }
        public int co_complemento { get; set; }

    }
}
