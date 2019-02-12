using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CAOL.Core.Entities
{
    [Table("cao_sistema")]
    public class cao_sistema
    {
        [Key]
        public int co_sistema { get; set; }
        public int co_cliente { get; set; }
        public string co_usuario { get; set; }
        public int co_arquitetura { get; set; }
        public string no_sistema { get; set; }
        public string ds_sistema_resumo { get; set; }
        public string ds_caracteristica { get; set; }
        public string ds_requisito { get; set; }
        public string no_diretoria_solic { get; set; }
        public string ddd_telefone_solic { get; set; }
        public string nu_telefone_solic { get; set; }
        public string no_usuario_solic { get; set; }
        public DateTime dt_solicitacao { get; set; }
        public DateTime dt_entrega { get; set; }
        public int co_email { get; set; }

    }
}
