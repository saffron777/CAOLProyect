using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CAOL.Core.Entities
{
    [Table("cao_os")]
    public class cao_os
    {
        [Key]
        public int co_os { get; set; }
        public int nu_os { get; set; }
        public int co_sistema { get; set; }
        public string co_usuario { get; set; }
        public int co_arquitetura { get; set; }
        public string ds_os { get; set; }
        public string ds_caracteristica { get; set; }
        public string ds_requisito { get; set; }
        public DateTime dt_inicio { get; set; }
        public DateTime dt_fim { get; set; }
        public int co_status { get; set; }
        public string diretoria_sol { get; set; }
        public DateTime dt_sol { get; set; }
        public string nu_tel_sol { get; set; }
        public string ddd_tel_sol { get; set; }
        public string nu_tel_sol2 { get; set; }
        public string ddd_tel_sol2 { get; set; }
        public string usuario_sol { get; set; }
        public DateTime dt_imp { get; set; }
        public DateTime dt_garantia { get; set; }
        public int co_email { get; set; }
        public int co_os_prospect_rel { get; set; }

    }
}
