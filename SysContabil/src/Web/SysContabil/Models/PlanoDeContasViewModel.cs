using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace SysContabil.Models
{
    public class PlanoDeContasViewModel
    {
        [DisplayName("Número da Conta:")]
        [Required(ErrorMessage = "Este campo é obrigatório!!")]
        public string NumeroDaConta { get; set; }

        [DisplayName("Nome da Conta:")]
        [Required(ErrorMessage = "Este campo é obrigatório!!")]
        public string NomeDaConta { get; set; }
    }
}
