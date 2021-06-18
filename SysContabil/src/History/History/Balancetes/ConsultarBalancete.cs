using Dominio.Entidades;
using Dominio.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace History.Balancetes
{
    public class ConsultarBalancete
    {
        private readonly IBalanceteRepository _balanceteRepository;

        public ConsultarBalancete(IBalanceteRepository balanceteRepository)
        {
            _balanceteRepository = balanceteRepository;
        }
        public async Task<Balancete> BuscarPeloId(int id)
        {
            return await _balanceteRepository.BuscaPorID(id);
        }
        public async Task<IEnumerable<Balancete>> ListarTodosBalancetes()
        {
            return await _balanceteRepository.ListarTodosBalancetes();
        }
    }
}
