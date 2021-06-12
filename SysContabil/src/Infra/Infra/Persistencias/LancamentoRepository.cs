using Dominio.Entidades;
using Dominio.IRepositories;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Persistencias
{
    public class LancamentoRepository : ILancamentoRepository
    {
        private readonly DataContext _dataContext;

        public LancamentoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Criar(Lancamento lancamento)
        {
            _dataContext.Lancamentos.Add(lancamento);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Alterar(Lancamento lancamento)
        {
            _dataContext.Update(lancamento);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Excluir(Lancamento lancamento)
        {
            _dataContext.Remove(lancamento);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<Lancamento> BuscaPorID(int id)
        {
            var lancamento = await _dataContext.Lancamentos.FirstOrDefaultAsync(x => x.Id == id);
            return lancamento;
        }

        public async Task<IEnumerable<Lancamento>> ListarTodosLancamentos()
        {
            return await _dataContext.Lancamentos.AsNoTracking().ToListAsync();
        }
    }
}
