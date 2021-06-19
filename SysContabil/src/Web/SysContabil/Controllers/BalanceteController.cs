using Dominio.IRepositories;
using History.Balancetes;
using Infra.Contexto;
using Microsoft.AspNetCore.Mvc;
using SysContabil.Factories;
using System.Threading.Tasks;

namespace SysContabil.Controllers
{
    public class BalanceteController : Controller
    {
        private readonly ConsultarBalancete _consultarBalancete;
        public BalanceteController(IBalanceteRepository balanceteRepository)
        {
            _consultarBalancete = new ConsultarBalancete(balanceteRepository);
        }

        public async Task<IActionResult> Index()
        {
            var listaBalancetes = await _consultarBalancete.ListarTodosBalancetes();
            var listaBalancetesViewModel = BalanceteFactory.MapearListaBalanceteViewModel(listaBalancetes);
            return View(listaBalancetesViewModel);
        }
    }
}

