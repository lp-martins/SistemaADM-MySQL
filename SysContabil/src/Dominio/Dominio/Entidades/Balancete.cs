using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Balancete
    {
        public Balancete(string nomeDaConta, string numeroDaConta, decimal saldo)
        {
            NomeDaConta = nomeDaConta;
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
        }

        public int Id { get; private set; }
        public string NomeDaConta { get; set; }
        public string NumeroDaConta { get; set; }
        public decimal Saldo { get; set; }

        public IEnumerable<PlanoDeConta> PlanoDeContas { get; private set; }

    }
}
