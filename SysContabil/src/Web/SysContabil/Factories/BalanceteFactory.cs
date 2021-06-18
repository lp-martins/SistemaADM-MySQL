using Dominio.Entidades;
using SysContabil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysContabil.Factories
{
    public static class BalanceteFactory
    {
        public static BalanceteViewModel MapearBalanceteViewModel(Balancete balancete)
        {
            var balanceteViewModel = new BalanceteViewModel
            {
                Id = balancete.Id,
                NomeDaConta = balancete.NomeDaConta,
                NumeroDaConta = balancete.NumeroDaConta,
                Saldo = balancete.Saldo
            };
            return balanceteViewModel;
        }
        public static Balancete MapearBalancete(BalanceteViewModel balanceteViewModel)
        {
            var balancete = new Balancete
                (
                balanceteViewModel.NomeDaConta,
                balanceteViewModel.NumeroDaConta,
                balanceteViewModel.Saldo
                );
            return balancete;
        }
        public static IEnumerable<BalanceteViewModel> MapearListaBalanceteViewModel(IEnumerable<Balancete> balancetes)
        {
            var lista = new List<BalanceteViewModel>();
            foreach(var item in balancetes)
            {
                lista.Add(MapearBalanceteViewModel(item));
            }
            return lista;
        }
    }
}
