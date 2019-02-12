using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Models.Response
{
    public class RelatorioModel
    {
        public string codigo { get; set; }
        public string name { get; set; }

        public DateTime data_emissao { get; set; }
        public float total_imp_inc { get; set; }
        public float valor { get; set; }
        public float comissao_cn { get; set; }
        public float brut_salario { get; set; }
    }
    

    public class RelatorioViewModel: ConsultoresResponse
    {
        public List<ItemsRelatorio> Items { get; set; }
        public decimal Saldo { get; set; }

        public ErrorResponse Error { get; set; }
    }

    public class ItemsRelatorio
    {
        public string Periodo { get; set; }
        public decimal ReceitaLiq { get; set; }
        public decimal CustoFixo { get; set; }
        public decimal Comissao { get; set; }
        public decimal Lucro { get; set; }
    }
}
