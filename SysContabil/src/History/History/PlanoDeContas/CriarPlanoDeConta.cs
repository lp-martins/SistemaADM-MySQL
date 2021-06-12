using Dominio.Entidades;
using Dominio.IRepositories;
using System.Threading.Tasks;

namespace History.PlanoDeContas
{
    public class CriarPlanoDeConta
    {
        private readonly IPlanoDeContaRepository _planoDeContaRepository;
        public CriarPlanoDeConta(IPlanoDeContaRepository planoDeContaRepository)
        {
            _planoDeContaRepository = planoDeContaRepository;
        }
        public async Task Executar(PlanoDeConta planoDeConta)
        {
            await _planoDeContaRepository.Criar(planoDeConta);
        }
    }
}
