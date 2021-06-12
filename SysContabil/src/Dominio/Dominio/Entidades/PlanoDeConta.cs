using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class PlanoDeConta
    {
        public PlanoDeConta(string numeroDaConta, string nomeDaConta)
        {
            NumeroDaConta = numeroDaConta;
            NomeDaConta = nomeDaConta;
        }

        public string NumeroDaConta { get; set; }
        public string NomeDaConta { get; set; }

        public IEnumerable<Lancamento> Lancamentos { get; private set; }

        public void AtualizarPlanoDeConta(string numeroDaConta, string nomeDaConta)
        {
            this.NumeroDaConta = numeroDaConta;
            this.NomeDaConta = nomeDaConta;
        }
    }
}
