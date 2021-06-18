using Dominio.IRepositories;
using History.Lancamentos;
using History.PlanoDeContas;
using Infra.Contexto;
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
        private readonly ConsultarPlanoDeConta _consultarPlanoDeConta;

        public LancamentoController(ILancamentoRepository lancamentoRepository, IPlanoDeContaRepository planoDeContaRepository)
        {
            _criarLancamento = new CriarLancamento(lancamentoRepository);
            _alterarLancamento = new AlterarLancamento(lancamentoRepository);
            _excluirLancamento = new ExcluirLancamento(lancamentoRepository);
            _consultarLancamento = new ConsultarLancamento(lancamentoRepository);

            _consultarPlanoDeConta = new ConsultarPlanoDeConta(planoDeContaRepository);
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

                var contaDebito = lancamentoViewModel.Debito;
                var contaCredito = lancamentoViewModel.Credito;

                var listaDePlanoDeContasDebito = await _consultarPlanoDeConta.BuscarPeloId(contaDebito);
                var listaDePlanoDeContaCredito = await _consultarPlanoDeConta.BuscarPeloId(contaCredito);

                if(listaDePlanoDeContaCredito != null && listaDePlanoDeContasDebito != null)
                {
                    await _criarLancamento.Executar(lancamento);
                    TempData["Mensagem"] = "Salvo com sucesso!";
                }
                else
                {
                    TempData["Mensagem"] = "VERIFIQUE AS CONTAS 'DÉBITO' E 'CRÉDITO', POIS UMA OU AMBAS, NÃO ESTÃO NO PLANO DE CONTAS!!!";
                }
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
