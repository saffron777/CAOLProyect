﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CAOL.Core.Entities
{
    [Table("cao_fatura_pag")]
    public class cao_fatura_pag
    {
        [Key]
        public int id_fatura_pag { get; set; }

        public int co_fatura { get; set; }
        public DateTime dt_efetuado { get; set; }
        public float valor_pago { get; set; }

    }
}
