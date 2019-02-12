using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CAOL.Core.Entities
{
    [Table("permissao_sistema")]
    public class permissao_sistema
    {
        [Key]
        [Column(Order = 1)]
        public string co_usuario { get; set; }
        [Key]
        [Column(Order = 2)]
        public long co_tipo_usuario { get; set; }
        [Key]
        [Column(Order = 3)]
        public long co_sistema { get; set; }
        public string in_ativo { get; set; }
        public string co_usuario_atualizacao { get; set; }
        public DateTime dt_atualizacao { get; set; }

    }
}
