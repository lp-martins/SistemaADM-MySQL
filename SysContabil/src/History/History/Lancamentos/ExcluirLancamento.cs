using Dominio.Entidades;
using Dominio.IRepositories;
using System.Threading.Tasks;

namespace History.Lancamentos
{
    public class ExcluirLancamento
    {
        private readonly ILancamentoRepository _lancamentoRepository;

        public ExcluirLancamento(ILancamentoRepository lancamentoRepository)
        {
            _lancamentoRepository = lancamentoRepository;
        }

        public async Task Executar(Lancamento lancamento)
        {
            await _lancamentoRepository.Excluir(lancamento);
        }
    }
}
