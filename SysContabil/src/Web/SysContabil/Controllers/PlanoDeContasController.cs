using Dominio.IRepositories;
using History.PlanoDeContas;
using Microsoft.AspNetCore.Mvc;
using SysContabil.Factories;
using SysContabil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysContabil.Controllers
{
    public class PlanoDeContasController : Controller
    {
        private readonly CriarPlanoDeConta _criarPlanoDeConta;
        private readonly AlterarPlanoDeConta _alterarPlanoDeConta;
        private readonly ExcluirPlanoDeConta _excluirPlanoDeConta;
        private readonly ConsultarPlanoDeConta _consulstarPlanoDeConta;
        public PlanoDeContasController(IPlanoDeContaRepository planoDeContaRepository)
        {
            _criarPlanoDeConta = new CriarPlanoDeConta(planoDeContaRepository);
            _alterarPlanoDeConta = new AlterarPlanoDeConta(planoDeContaRepository);
            _excluirPlanoDeConta = new ExcluirPlanoDeConta(planoDeContaRepository);
            _consulstarPlanoDeConta = new ConsultarPlanoDeConta(planoDeContaRepository);
        }
        public IActionResult Index()
        {
            return View();
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
                return RedirectToAction("Index");
            }
            return View(planoDeContasViewModel);
        }
        public async Task<IActionResult> Alterar(string id)
        {
            var planoDeConta = await _consulstarPlanoDeConta.BuscarPeloId(id);
            if(planoDeConta == null)
            {
                return RedirectToAction("Index");
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
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detalhar(string id)
        {
            var planoDeConta = await _consulstarPlanoDeConta.BuscarPeloId(id);
            if(planoDeConta == null)
            {
                return RedirectToAction("Index");
            }
            var planoDeContaViewModel = PlanoDecontaFactory.MapearPlanoDeContaViewModel(planoDeConta);
            return View(planoDeContaViewModel);
        }
        public async Task<IActionResult> Excluir(string id)
        {
            var planoDeConta = await _consulstarPlanoDeConta.BuscarPeloId(id);
            if(planoDeConta == null)
            {
                return RedirectToAction("Index");
            }
            await _excluirPlanoDeConta.Executar(planoDeConta);
            return RedirectToAction("Index");
        }
    }
}
