using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class PlanoDeConta
    {
        public PlanoDeConta(string nomeDaConta)
        {
            NomeDaConta = nomeDaConta;
        }
        public PlanoDeConta(string numeroDaConta, string nomeDaConta)
        {
            NumeroDaConta = numeroDaConta;
            NomeDaConta = nomeDaConta;
        }

        public string NumeroDaConta { get; private set; }
        public string NomeDaConta { get; private set; }

        public Balancete Balancete { get; private set; }

        public IEnumerable<Lancamento> Lancamentos { get; private set; }

        public void AtualizarPlanoDeConta(string numeroDaConta, string nomeDaConta)
        {
            this.NumeroDaConta = numeroDaConta;
            this.NomeDaConta = nomeDaConta;
        }
    }
}
