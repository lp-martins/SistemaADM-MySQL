using Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IPlanoDeContaRepository
    {
        Task Criar(PlanoDeConta planoDeConta);
        Task Alterar(PlanoDeConta planoDeConta);
        Task Excluir(PlanoDeConta planoDeConta);
        Task<PlanoDeConta> BuscaPorId(string id);
        Task<PlanoDeConta> BuscarPorNome(string nomeDaConta);
        Task<IEnumerable<PlanoDeConta>> ListarTodosPlanoDeContas();
    }
}
