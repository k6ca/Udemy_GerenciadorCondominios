using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GerenciadorCondominios.BLL.Models
{
	public class Veiculo()
	{
		public int VeiculoId { get; set; }

		[Required(ErrorMessage = "O campo {0} é opbrigatório")]
		[StringLength(20, ErrorMessage = "Até 20 caracteres")]
		public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é opbrigatório")]
        [StringLength(20, ErrorMessage = "Até 20 caracteres")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O campo {0} é opbrigatório")]
        [StringLength(20, ErrorMessage = "Até 20 caracteres")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "O campo {0} é opbrigatório")]
        public string Placa { get; set; }
		public string UsusarioId { get; set; }
		public Usuario Usuario { get; set; }

	}
}
