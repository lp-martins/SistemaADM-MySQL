using Dominio.Entidades;
using Dominio.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace History.Lancamentos
{
    public class ConsultarLancamento
    {
        private readonly ILancamentoRepository _lancamentoRepository;
        public ConsultarLancamento(ILancamentoRepository lancamentoRepository)
        {
            _lancamentoRepository = lancamentoRepository;
        }
        public async Task<Lancamento> BuscarPeloId(int id)
        {
            return await _lancamentoRepository.BuscaPorID(id);
        }
        public async Task<IEnumerable<Lancamento>> ListarTodosLancamentos()
        {
            return await _lancamentoRepository.ListarTodosLancamentos();
        }
    }
}
