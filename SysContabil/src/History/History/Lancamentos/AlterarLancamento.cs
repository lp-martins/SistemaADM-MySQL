using Dominio.Entidades;
using Dominio.IRepositories;
using System.Threading.Tasks;

namespace History.Lancamentos
{
    public class AlterarLancamento
    {
        private readonly ILancamentoRepository _lancamentoRepository;

        public AlterarLancamento(ILancamentoRepository lancamentoRepository)
        {
            _lancamentoRepository = lancamentoRepository;
        }

        public async Task Executar(int id, Lancamento lancamento)
        {
            var dadosDoLancamento = await _lancamentoRepository.BuscaPorID(id);
            dadosDoLancamento.AtualizarLancamento(lancamento.Data, lancamento.Debito, lancamento.Credito, lancamento.Valor, lancamento.ReciboFiscal);
            await _lancamentoRepository.Alterar(dadosDoLancamento);
        }
    }
}
