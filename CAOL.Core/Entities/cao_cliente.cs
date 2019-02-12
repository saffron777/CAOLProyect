using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CAOL.Core.Entities
{
    [Table("cao_cliente")]
    public class cao_cliente
    {
        [Key]
        public int co_cliente { get; set; }
        public string no_razao { get; set; }
        public string no_fantasia { get; set; }
        public string no_contato { get; set; }
        public string nu_telefone { get; set; }
        public string nu_ramal { get; set; }
        public string nu_cnpj { get; set; }
        public string ds_endereco { get; set; }
        public int nu_numero { get; set; }
        public string ds_complemento { get; set; }
        public string no_bairro { get; set; }
        public string nu_cep { get; set; }
        public string no_pais { get; set; }
        public int co_ramo { get; set; }
        public int co_cidade { get; set; }
        public int co_status { get; set; }
        public string ds_site { get; set; }
        public string ds_email { get; set; }
        public string ds_cargo_contato { get; set; }
        public string tp_cliente { get; set; }
        public string ds_referencia { get; set; }
        public int co_complemento_status { get; set; }
        public string nu_fax { get; set; }
        public string ddd2 { get; set; }
        public string telefone2 { get; set; }

    }
}
