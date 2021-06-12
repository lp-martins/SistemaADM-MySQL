using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace History.Lancamentos
{
    public class CriarLancamento
    {
        private readonly ILancamentoRepository _lancamentoRepository;

        public CriarLancamento(ILancamentoRepository lancamentoRepository)
        {
            _lancamentoRepository = lancamentoRepository;
        }

        public async Task Executar(Lancamento lancamento)
        {
            await _lancamentoRepository.Criar(lancamento);
        }
    }
}
