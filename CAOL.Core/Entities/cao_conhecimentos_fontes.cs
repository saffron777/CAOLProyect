using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Entities
{
    public class cao_conhecimentos_fontes
    {
        public int idfonte { get; set; }
        public int idconhecimento { get; set; }
        public DateTime datahora { get; set; }
        public string arquivo { get; set; }
        public string caminho { get; set; }

    }
}
