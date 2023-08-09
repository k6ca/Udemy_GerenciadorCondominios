using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.BLL.Models
{
	public class Evento()
	{
		public int EventoId { get; set; }

		[Required(ErrorMessage = "O Campo {0} é obrigatório")]
		[StringLength(50, ErrorMessage = "Use menos caracteres")]
		public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public DateTime Data { get; set; }
		public int UsusarioId { get; set; }
		public virtual Usuario Usuario { get; set; }
	}
}
