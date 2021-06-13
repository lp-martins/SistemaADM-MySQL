using Dominio.Entidades;
using SysContabil.Models;
using System.Collections.Generic;

namespace SysContabil.Factories
{
    public static class PlanoDecontaFactory
    {
        public static PlanoDeContasViewModel MapearPlanoDeContaViewModel(PlanoDeConta planoDeConta)
        {
            var planoDeContaViewModel = new PlanoDeContasViewModel
            {
                NumeroDaConta = planoDeConta.NumeroDaConta,
                NomeDaConta = planoDeConta.NomeDaConta
            };
            return planoDeContaViewModel;
        }
        public static PlanoDeConta MapearPlanoDeConta(PlanoDeContasViewModel planoDeContasViewModel)
        {
            var planoDeConta = new PlanoDeConta(
                planoDeContasViewModel.NumeroDaConta,
                planoDeContasViewModel.NomeDaConta
                );
            return planoDeConta;
        }
        public static IEnumerable<PlanoDeContasViewModel>MapearListaPlanoDeContasViewModel(IEnumerable<PlanoDeConta> planoDeContas)
        {
            var lista = new List<PlanoDeContasViewModel>();
            foreach(var item in planoDeContas)
            {
                lista.Add(MapearPlanoDeContaViewModel(item));
            }
            return lista;
        }
    }
}
