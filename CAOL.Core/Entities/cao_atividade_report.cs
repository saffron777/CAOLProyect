using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Entities
{
    public class cao_atividade_report
    {
        public int id { get; set; }
        public int co_cliente { get; set; }
        public string inicio { get; set; }
        public string fim { get; set; }
        public string lembrete { get; set; }
        public int co_atividade { get; set; }
        public int co_os { get; set; }
        public string assunto { get; set; }
        public string conteudo { get; set; }
        public string status { get; set; }
        public string tempo { get; set; }
        public string co_usuario { get; set; }
        public DateTime data_ativ { get; set; }
        public string retorno { get; set; }
        public int co_fase { get; set; }

    }
}
