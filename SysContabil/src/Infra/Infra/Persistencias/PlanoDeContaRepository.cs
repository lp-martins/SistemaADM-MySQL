using Dominio.Entidades;
using Dominio.IRepositories;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Persistencias
{
    public class PlanoDeContaRepository : IPlanoDeContaRepository
    {
        private readonly DataContext _dataContext;
        public PlanoDeContaRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Criar(PlanoDeConta planoDeConta)
        {  
            _dataContext.PlanoDeContas.Add(planoDeConta);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Alterar(PlanoDeConta planoDeConta)
        {
            _dataContext.Update(planoDeConta);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Excluir(PlanoDeConta planoDeConta)
        {
            _dataContext.Remove(planoDeConta);
            await _dataContext.SaveChangesAsync();
        }
        public async Task<PlanoDeConta> BuscaPorId(string id)
        {
            var planoDeConta = await _dataContext.PlanoDeContas.FirstOrDefaultAsync(x => x.NumeroDaConta == id);
            return planoDeConta;
        }
        public async Task<IEnumerable<PlanoDeConta>> ListarTodosPlanoDeContas()
        {
            return await _dataContext.PlanoDeContas.AsNoTracking().ToListAsync();
        }
    }
}
