using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GerenciadorCondominios.BLL.Models
{
	public class Aluguel()
	{
		public int AluguelId { get; set; }

        [Required(ErrorMessage = "O campo {0} é opbrigatório")]
		[Range(0, int.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal Valor { get; set; }

		[Display(namespace="Mês")]
		public int MesId { get; set; }
		public Mes Mes { get; set; }

	    [Required(ErrorMessage = "O campo {0} é opbrigatório")]
		[Range(2020, 2030, ErrorMessage = "Valor inválido")]
		public int Ano { get; set; }

		public virtual ICollection<Pagamento> Pagamentos { get; set; }
	}
}
