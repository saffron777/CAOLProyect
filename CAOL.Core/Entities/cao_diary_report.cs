using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Entities
{
    public class cao_diary_report
    {
        public int co_diary_report { get; set; }
        public TimeSpan hr_gasta { get; set; }
        public int co_atividade { get; set; }
        public string ds_assunto { get; set; }
        public long co_movimento { get; set; }
        public long nu_os { get; set; }
        public long co_sistema { get; set; }

    }
}
