using Dominio.Entidades;
using Dominio.IRepositories;
using System.Threading.Tasks;

namespace History.PlanoDeContas
{
    public class ExcluirPlanoDeConta
    {
        private readonly IPlanoDeContaRepository _planoDeContaRepository;
        public ExcluirPlanoDeConta(IPlanoDeContaRepository planoDeContaRepository)
        {
            _planoDeContaRepository = planoDeContaRepository;
        }
        public async Task Executar(PlanoDeConta planoDeConta)
        {
            await _planoDeContaRepository.Excluir(planoDeConta);
        }
    }
}
