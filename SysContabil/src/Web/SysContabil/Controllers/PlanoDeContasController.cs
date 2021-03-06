using Dominio.IRepositories;
using History.PlanoDeContas;
using Microsoft.AspNetCore.Mvc;
using SysContabil.Factories;
using SysContabil.Models;
using System.Threading.Tasks;

namespace SysContabil.Controllers
{
    public class PlanoDeContasController : Controller
    {
        private readonly CriarPlanoDeConta _criarPlanoDeConta;
        private readonly AlterarPlanoDeConta _alterarPlanoDeConta;
        private readonly ExcluirPlanoDeConta _excluirPlanoDeConta;
        private readonly ConsultarPlanoDeConta _consultarPlanoDeConta;
        public PlanoDeContasController(IPlanoDeContaRepository planoDeContaRepository)
        {
            _criarPlanoDeConta = new CriarPlanoDeConta(planoDeContaRepository);
            _alterarPlanoDeConta = new AlterarPlanoDeConta(planoDeContaRepository);
            _excluirPlanoDeConta = new ExcluirPlanoDeConta(planoDeContaRepository);
            _consultarPlanoDeConta = new ConsultarPlanoDeConta(planoDeContaRepository);
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(PlanoDeContasViewModel planoDeContasViewModel)
        {
            if (ModelState.IsValid)
            {
                var planoDeConta = PlanoDecontaFactory.MapearPlanoDeConta(planoDeContasViewModel);
                await _criarPlanoDeConta.Executar(planoDeConta);
                TempData["Mensagem"] = "Salvo com sucesso!";
                return View(planoDeContasViewModel);
            }
            return View(planoDeContasViewModel);
        }
        public async Task<IActionResult> ListarContas()
        {
            var listaPlanoDeContas = await _consultarPlanoDeConta.ListarTodosPlanoDeContas();
            var listaPlanoDeContasViewModel = PlanoDecontaFactory.MapearListaPlanoDeContasViewModel(listaPlanoDeContas);
            return View(listaPlanoDeContasViewModel);
        }
        public async Task<IActionResult> Alterar(string id)
        {
            var planoDeConta = await _consultarPlanoDeConta.BuscarPeloId(id);
            if(planoDeConta == null)
            {
                return RedirectToAction("Criar");
            }
            var planoDeContaViewModel = PlanoDecontaFactory.MapearPlanoDeContaViewModel(planoDeConta);
            return View(planoDeContaViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Alterar(string id, PlanoDeContasViewModel planoDeContasViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(planoDeContasViewModel);
            }
            var planoDeConta = PlanoDecontaFactory.MapearPlanoDeConta(planoDeContasViewModel);
            await _alterarPlanoDeConta.Executar(id, planoDeConta);
            return RedirectToAction("ListarContas");
        }
        public async Task<IActionResult> Detalhar(string id)
        {
            var planoDeConta = await _consultarPlanoDeConta.BuscarPeloId(id);
            if(planoDeConta == null)
            {
                return RedirectToAction("Criar");
            }
            var planoDeContaViewModel = PlanoDecontaFactory.MapearPlanoDeContaViewModel(planoDeConta);
            return View(planoDeContaViewModel);
        }
        public async Task<IActionResult> Excluir(string id)
        {
            var planoDeConta = await _consultarPlanoDeConta.BuscarPeloId(id);
            if(planoDeConta == null)
            {
                return RedirectToAction("ListarContas");
            }
            await _excluirPlanoDeConta.Executar(planoDeConta);
            return RedirectToAction("ListarContas");
        }
    }
}
