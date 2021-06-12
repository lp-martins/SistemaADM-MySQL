using Dominio.IRepositories;
using History.Lancamentos;
using Microsoft.AspNetCore.Mvc;
using SysContabil.Factories;
using SysContabil.Models;
using System.Threading.Tasks;

namespace SysContabil.Controllers
{
    public class LancamentoController : Controller
    {
        private readonly CriarLancamento _criarLancamento;

        public LancamentoController(ILancamentoRepository lancamentoRepository)
        {
            _criarLancamento = new CriarLancamento(lancamentoRepository);
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(LancamentoViewModel lancamentoViewModel)
        {
            if (ModelState.IsValid)
            {
                var lancamento = LancamentoFactory.MapearLancamento(lancamentoViewModel);
                await _criarLancamento.Executar(lancamento);
                return RedirectToAction("Criar");
            }
            return View(lancamentoViewModel);
        }
    }
}
