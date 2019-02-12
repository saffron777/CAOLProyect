using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CAOL.Core.Entities
{
    [Table("cao_salario")]
    public class cao_salario
    {
        [Key]        
        public string co_usuario { get; set; }
        [Key]        
        public DateTime dt_alteracao { get; set; }
        public float brut_salario { get; set; }
        public float liq_salario { get; set; }

    }
}
