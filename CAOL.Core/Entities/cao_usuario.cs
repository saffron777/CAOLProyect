using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CAOL.Core.Entities
{
    [Table("cao_usuario")]
    public class cao_usuario
    {
        [Key]
        public string co_usuario { get; set; }
        public string no_usuario { get; set; }
        public string ds_senha { get; set; }
        public string co_usuario_autorizacao { get; set; }
        public long nu_matricula { get; set; }
        public DateTime dt_nascimento { get; set; }
        public DateTime dt_admissao_empresa { get; set; }
        public DateTime dt_desligamento { get; set; }
        public DateTime dt_inclusao { get; set; }
        public DateTime dt_expiracao { get; set; }
        public string nu_cpf { get; set; }
        public string nu_rg { get; set; }
        public string no_orgao_emissor { get; set; }
        public string uf_orgao_emissor { get; set; }
        public string ds_endereco { get; set; }
        public string no_email { get; set; }
        public string no_email_pessoal { get; set; }
        public string nu_telefone { get; set; }
        public DateTime dt_alteracao { get; set; }
        public string url_foto { get; set; }
        public string instant_messenger { get; set; }
        public int icq { get; set; }
        public string msn { get; set; }
        public string yms { get; set; }
        public string ds_comp_end { get; set; }
        public string ds_bairro { get; set; }
        public string nu_cep { get; set; }
        public string no_cidade { get; set; }
        public string uf_cidade { get; set; }
        public DateTime dt_expedicao { get; set; }

    }
}
