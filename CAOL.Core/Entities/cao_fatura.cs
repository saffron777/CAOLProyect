using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CAOL.Core.Entities
{
    [Table("cao_fatura")]
    public class cao_fatura
    {
        [Key]
        public int co_fatura { get; set; }
        public int co_cliente { get; set; }
        public int co_sistema { get; set; }
        public int co_os { get; set; }
        public int num_nf { get; set; }
        public float total { get; set; }
        public float valor { get; set; }
        public DateTime data_emissao { get; set; }
        public string corpo_nf { get; set; }
        public float comissao_cn { get; set; }
        public float total_imp_inc { get; set; }

    }
}
