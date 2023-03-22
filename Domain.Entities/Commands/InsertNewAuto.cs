using Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Commands
{
	public class InsertNewAuto
	{
		[Required] public string modelo { get; set; }

		[Required] public int Anio_fabricacion { get; set; }

		[Required]
		public int Id_marca { get; set; }

		[Required]
		public int Id_concesionario { get; set; }

	}
}
