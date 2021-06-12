using Dominio.Entidades;
using Dominio.IRepositories;
using System.Threading.Tasks;

namespace History.PlanoDeContas
{
    public class AlterarPlanoDeConta
    {
        private readonly IPlanoDeContaRepository _planoDeContaRepository;
        public AlterarPlanoDeConta(IPlanoDeContaRepository planoDeContaRepository)
        {
            _planoDeContaRepository = planoDeContaRepository;
        }
        public async Task Executar(string id, PlanoDeConta planoDeConta)
        {
            var dadosDoPlanoDeConta = await _planoDeContaRepository.BuscaPorId(id);
            dadosDoPlanoDeConta.AtualizarPlanoDeConta(planoDeConta.NumeroDaConta, planoDeConta.NomeDaConta);
            await _planoDeContaRepository.Alterar(dadosDoPlanoDeConta);
        }
    }
}
