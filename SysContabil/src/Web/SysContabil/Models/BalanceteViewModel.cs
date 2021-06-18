using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace SysContabil.Models
{
    public class BalanceteViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [DisplayName("Nome da conta:")]
        public string NomeDaConta { get; set; }

        [DisplayName("Número da conta:")]
        public string NumeroDaConta { get; set; }

        [DisplayName("Saldo:")]
        public decimal Saldo { get; set; }
    }
}
