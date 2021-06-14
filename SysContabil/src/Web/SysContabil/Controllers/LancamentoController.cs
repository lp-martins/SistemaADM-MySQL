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
        private readonly AlterarLancamento _alterarLancamento;
        private readonly ExcluirLancamento _excluirLancamento;
        private readonly ConsultarLancamento _consultarLancamento;
        public LancamentoController(ILancamentoRepository lancamentoRepository)
        {
            _criarLancamento = new CriarLancamento(lancamentoRepository);
            _alterarLancamento = new AlterarLancamento(lancamentoRepository);
            _excluirLancamento = new ExcluirLancamento(lancamentoRepository);
            _consultarLancamento = new ConsultarLancamento(lancamentoRepository);
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
                TempData["Mensagem"] = "Salvo com sucesso!";
                return View(lancamentoViewModel);
            }
            return View(lancamentoViewModel);
        }
        public async Task<IActionResult> ListarLancamentos()
        {
            var listaLancamentos = await _consultarLancamento.ListarTodosLancamentos();
            var listaLancamentosViewModel = LancamentoFactory.MapearListaLancamentoViewModel(listaLancamentos);
            return View(listaLancamentosViewModel);
        }
        public async Task<IActionResult> Alterar(int id)
        {
            var lancamento = await _consultarLancamento.BuscarPeloId(id);
            if(lancamento == null)
            {
                return RedirectToAction("ListarLancamentos");
            }
            var lancamentoViewModel = LancamentoFactory.MapearLancamentoViewModel(lancamento);
            return View(lancamentoViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Alterar(int id, LancamentoViewModel lancamentoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(lancamentoViewModel);
            }
            var lancamento = LancamentoFactory.MapearLancamento(lancamentoViewModel);
            await _alterarLancamento.Executar(id, lancamento);
            return RedirectToAction("ListarLancamentos");
        }
        public async Task<IActionResult> Detalhar(int id)
        {
            var lancamento = await _consultarLancamento.BuscarPeloId(id);
            if (lancamento == null)
            {
                return RedirectToAction("ListarLancamentos");
            }
            var lancamentoViewModel = LancamentoFactory.MapearLancamentoViewModel(lancamento);
            return View(lancamentoViewModel);
        }
        public async Task<IActionResult> Excluir(int id)
        {
            var lancamento = await _consultarLancamento.BuscarPeloId(id);
            if (lancamento == null)
            {
                return RedirectToAction("ListarLancamentos");
            }
            await _excluirLancamento.Executar(lancamento);
            return RedirectToAction("ListarLancamentos");
        }
    }
}
