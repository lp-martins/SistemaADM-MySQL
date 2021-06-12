using Dominio.Entidades;
using Dominio.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace History.PlanoDeContas
{
    public class ConsultarPlanoDeConta
    {
        private readonly IPlanoDeContaRepository _planoDeContaRepository;
        public ConsultarPlanoDeConta(IPlanoDeContaRepository planoDeContaRepository)
        {
            _planoDeContaRepository = planoDeContaRepository;
        }
        public async Task<PlanoDeConta>BuscarPeloId(string id)
        {
            return await _planoDeContaRepository.BuscaPorId(id);
        }
        public async Task<IEnumerable<PlanoDeConta>> ListarTodosPlanoDeContas()
        {
            return await _planoDeContaRepository.ListarTodosPlanoDeContas();
        }
    }
}
