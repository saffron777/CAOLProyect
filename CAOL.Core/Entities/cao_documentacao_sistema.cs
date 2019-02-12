using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Entities
{
    public class cao_documentacao_sistema
    {
        public int id { get; set; }
        public int co_sistema { get; set; }
        public string descricao { get; set; }
        public string pasta { get; set; }
        public int sub_grupo { get; set; }
        public string co_usuario { get; set; }
        public DateTime dt_doc { get; set; }
        public string arquivo { get; set; }

    }
}
