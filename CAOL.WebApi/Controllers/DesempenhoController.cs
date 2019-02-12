using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CAOL.Core.Utilities;
using CAOL.Core.Models.Response;
using CAOL.Core.Modules.Desempenho.Interface;

namespace CAOL.WebApi.Controllers
{
    
    [ApiController]
    public class DesempenhoController : ControllerBase
    {
        private readonly IDesempenhoService _desempenhoService;
        public DesempenhoController(IDesempenhoService desempenhoService)
        {
            _desempenhoService = desempenhoService;
        }

        [HttpGet]
        [Route("api/GetConsultores")]
        public GenericResponse<ConsultoresResponse> GetConsultores()
        {
            try
            {
                return _desempenhoService.GetConsultores();
            }
            catch (Exception ex)
            {

                return new GenericResponse<ConsultoresResponse> {
                     Error = new ErrorResponse { Status ="FAIL" , Message = ex.Message}
                };
            }
        }

        [HttpGet]
        [Route("api/GetClientes")]
        public GenericResponse<ClientesResponse> GetClientes()
        {
            try
            {
                return _desempenhoService.GetClientes();
            }
            catch (Exception ex)
            {

                return new GenericResponse<ClientesResponse>
                {
                    Error = new ErrorResponse { Status = "FAIL", Message = ex.Message }
                };
            }
        }
    }
}