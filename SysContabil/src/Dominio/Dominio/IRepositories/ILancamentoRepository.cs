using Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface ILancamentoRepository
    {
        Task Criar(Lancamento lancamento);
        Task Alterar(Lancamento lancamento);
        Task Excluir(Lancamento lancamento);
        Task<Lancamento> BuscaPorID(int id);
        Task<IEnumerable<Lancamento>> ListarTodosLancamentos();
    }
}
