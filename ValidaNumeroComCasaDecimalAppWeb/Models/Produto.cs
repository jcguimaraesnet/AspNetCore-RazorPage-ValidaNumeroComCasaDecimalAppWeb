using System.ComponentModel.DataAnnotations;

namespace ValidaNumeroComCasaDecimalAppWeb.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public double Valor { get; private set; }

        [Required(ErrorMessage = "Campo 'Valor' obrigatório.")]
        [RegularExpression(@"^\d+(\,\d{1,2})?$", ErrorMessage = "Campo 'Valor' inválido.")]
        public string ValorString
        {
            get { return Valor.ToString(); }
            set { Valor = double.Parse(value); }
        }
    }
}
