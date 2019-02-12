using System;
using System.Collections.Generic;
using System.Text;
using CAOL.Core.Models.Response;

namespace CAOL.Core.Modules.Desempenho.Interface
{
    public interface IDesempenhoService
    {
        GenericResponse<ClientesResponse> GetClientes();

        GenericResponse<ConsultoresResponse> GetConsultores();

        RelatorioViewModel GetRelatorio(string type,DateTime dtini, DateTime dtfin, List<string> consultoresList);

    }
}
