using Dominio.Entidades;
using SysContabil.Models;
using System.Collections.Generic;

namespace SysContabil.Factories
{
    public static class LancamentoFactory
    {
        public static LancamentoViewModel MapearLancamentoViewModel(Lancamento lancamento)
        {
            var lancamentoViewModel = new LancamentoViewModel
            {
                Id = lancamento.Id,
                DataDoPlano = lancamento.Data,
                Debito = lancamento.Debito,
                Credito = lancamento.Credito,
                Valor = lancamento.Valor,
                ReciboFiscal = lancamento.ReciboFiscal
            };
            return lancamentoViewModel;
        }

        public static Lancamento MapearLancamento(LancamentoViewModel lancamentoViewModel)
        {
            var lancamento = new Lancamento(
                lancamentoViewModel.DataDoPlano,
                lancamentoViewModel.Debito,
                lancamentoViewModel.Credito,
                lancamentoViewModel.Valor,
                lancamentoViewModel.ReciboFiscal
                );
            return lancamento;
        }

        public static IEnumerable<LancamentoViewModel> MapearListaLancamentoViewModel(IEnumerable<Lancamento> lancamentos)
        {
            var lista = new List<LancamentoViewModel>();
            foreach (var item in lancamentos)
            {
                lista.Add(MapearLancamentoViewModel(item));
            }
            return lista;
        }
    }
}
