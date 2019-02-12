using System;
using System.Collections.Generic;
using System.Text;
using CAOL.Core.Utilities;
using CAOL.Core.Entities;
using CAOL.Core.Models.Response;

using CAOL.Core.Modules.Desempenho.Interface;
using CAOL.Core.Repository.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Linq.Expressions;

namespace CAOL.Core.Modules.Desempenho.Implementations
{
    public class DesempenhoService : IDesempenhoService
    {
        private readonly IConfiguration _configuration;
        private readonly ICao_clienteRepository _clienteRepository;
        private readonly ICao_faturaRepository _faturaRepository;
        private readonly ICao_osRepository _osRepository;
        private readonly ICao_salarioRepository _salarioRepository;
        private readonly ICao_sistemaRepository _sistemaRepository;
        private readonly ICao_usuarioRepository _usuarioRepository;
        private readonly IPermissao_sistemaRepository _permissaoSistemaRepository;

        private List<long> m_tipo_usuario = new List<long>() { 0, 1, 2 };
        const long _COSISTEMA = 1;
        const string _INATIVO = "S";

        public DesempenhoService(IConfiguration configuration, 
            ICao_clienteRepository clienteRepository, 
            ICao_faturaRepository faturaRepository, 
            ICao_osRepository osRepository,
            ICao_salarioRepository salarioRepository,
            ICao_usuarioRepository usuarioRepository,
            IPermissao_sistemaRepository permissaoSistemaRepository,
            ICao_sistemaRepository sistemaRepository)
        {
            _configuration = configuration;
            _clienteRepository = clienteRepository;
            _faturaRepository = faturaRepository;
            _osRepository = osRepository;
            _salarioRepository = salarioRepository;
            _usuarioRepository = usuarioRepository;
            _permissaoSistemaRepository = permissaoSistemaRepository;
            _sistemaRepository = sistemaRepository;
        }
        public GenericResponse<ClientesResponse> GetClientes()
        {
            

            try
            {
                var clientes = _clienteRepository.Get()
                       .Join(_sistemaRepository.Get(), t => t.co_cliente, l => l.co_cliente, (t, l) => new { t, l })
                       .Select(s => new ClientesResponse { co_cliente = s.t.co_cliente,  no_razao = s.t.no_razao }).ToList();


                var result = new GenericResponse<ClientesResponse>
                {
                    Data = clientes,
                    Error = new ErrorResponse { Status = "OK", Message = "" }
                };

                return result;
            }
            catch (Exception ex)
            {

                var result = new GenericResponse<ClientesResponse>
                {
                    Data = null,
                    Error = new ErrorResponse { Status = "FAIL", Message = ex.Message }
                };

                return result;
            }
        }

        public GenericResponse<ConsultoresResponse> GetConsultores()
        {
            
            Expression<Func<permissao_sistema, bool>> expression =  per => per.co_sistema == _COSISTEMA && per.in_ativo == _INATIVO && m_tipo_usuario.Contains(per.co_tipo_usuario);

            try
            {
                var consultores = _permissaoSistemaRepository.Get(expression)
                       .Join(_usuarioRepository.Get(), t => t.co_usuario, l => l.co_usuario, (t, l) => new { t, l })
                       .Select(s => new ConsultoresResponse { co_usuario = s.l.co_usuario, no_usuario = s.l.no_usuario }).ToList();


                var result = new GenericResponse<ConsultoresResponse>
                {
                    Data = consultores,
                    Error = new ErrorResponse { Status = "OK", Message = "" }
                };

                return result;
            }
            catch (Exception ex)
            {
                var result = new GenericResponse<ConsultoresResponse>
                {                    
                    Error = new ErrorResponse { Status = "FAIL", Message = ex.Message }
                };

                return result;
            }

        }

        public RelatorioViewModel GetRelatorio(string type, DateTime dtini, DateTime dtfin, List<string> consultoresList)
        {
            var result = new RelatorioViewModel();

            try
            {
                int mesini = dtini.Month;
                int mesfin = dtfin.Month;


                var relatorio = _faturaRepository.Get()
                    .Join(_clienteRepository.Get(), f => f.co_cliente, c => c.co_cliente, (f, c) => new { f, c })
                    .Join(_sistemaRepository.Get(), c => c.c.co_cliente, s => s.co_cliente, (c, s) => new { c, s })
                    .Join(_salarioRepository.Get(), s => s.s.co_usuario, sal => sal.co_usuario, (s, sal) => new { s, sal })
                    .Join(_osRepository.Get(), s => s.s.s.co_sistema, os => os.co_sistema, (s, os) => new { s, os })
                    .Where(w => w.s.s.c.f.data_emissao.Date >= dtini.Date && w.s.s.c.f.data_emissao.Date <= dtfin.Date)
                    .OrderBy(order => order.s.s.c.f.data_emissao)
                    .OrderBy(order => order.s.s.c.c.co_cliente)
                    
                    .ToList();


                //var sql = "select " +
                //        "c.co_cliente, " +
                //        "c.no_razao, " +
                //        "f.data_emissao, " +
                //        "f.total_imp_inc, " +
                //        "f.valor, " +
                //        "f.comissao_cn, " +
                //        "sal.brut_salario " +
                //        "from CAO_FATURA f " +
                //        "inner join cao_cliente c on f.CO_CLIENTE = c.CO_CLIENTE " +
                //        "inner join CaO_SISTEMA s on s.co_cliente = c.CO_CLIENTE " +
                //        "inner join cao_salario sal on sal.co_usuario = s.co_usuario " +
                //        "inner join cao_os os on os.co_sistema = s.co_sistema " +
                //        "where concat(year(data_emissao), LPAD(month(data_emissao),2,'0'), LPAD(day(data_emissao), 2, '0')) between '20070201' and '20070430' " +
                //        "order by data_emissao asc, co_cliente";


                for (int i = mesini; i <= mesfin; i++)
                {

                }
            }
            catch (Exception ex)
            {

                result = new RelatorioViewModel
                {                    
                    Error = new ErrorResponse { Status = "FAIL", Message = ex.Message }
                };

                
            }

            return result;
        }
    }
}
