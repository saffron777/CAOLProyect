using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Entities
{
    public class cao_conhecimentos
    {
        public int idconhecimento { get; set; }
        public string assunto { get; set; }
        public string conhecimento { get; set; }
        public string tags { get; set; }
        public string usuario { get; set; }
        public DateTime datahora { get; set; }

    }
}
