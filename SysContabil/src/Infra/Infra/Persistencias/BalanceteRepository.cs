using Dominio.Entidades;
using Dominio.IRepositories;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistencias
{
    public class BalanceteRepository : IBalanceteRepository
    {
        private readonly DataContext _dataContext;
        public BalanceteRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Criar(Balancete balancete)
        {
            _dataContext.Balancetes.Add(balancete);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Alterar(Balancete balancete)
        {
            _dataContext.Update(balancete);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Excluir(Balancete balancete)
        {
            _dataContext.Remove(balancete);
            await _dataContext.SaveChangesAsync();
        }
        public async Task<Balancete> BuscaPorID(int id)
        {
            var balancete = await _dataContext.Balancetes.FirstOrDefaultAsync(x => x.Id == id);
            return balancete;
        }
        public async Task<IEnumerable<Balancete>> ListarTodosBalancetes()
        {
            return await _dataContext.Balancetes.AsNoTracking().ToListAsync();
        }
    }
}
