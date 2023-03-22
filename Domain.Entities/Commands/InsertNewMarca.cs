using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Commands
{
	public class InsertNewMarca
	{
		[Required]
		public string Nombre_marca { get; set; }

		public InsertNewMarca(string nombre_marca)
		{
			Nombre_marca = nombre_marca;
		}
	}
}
