using Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IBalanceteRepository
    {
        Task Criar(Balancete balancete);
        Task Alterar(Balancete balancete);
        Task Excluir(Balancete balancete);
        Task<Balancete> BuscaPorID(int id);
        Task<IEnumerable<Balancete>> ListarTodosBalancetes();
    }
}
