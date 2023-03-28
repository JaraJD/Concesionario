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
		public string modelo { get; set; }

		[Required(ErrorMessage = "El año de fabricacion es requerido")]
		public int Anio_fabricacion { get; set; }

		[Required(ErrorMessage = "El id de la marca es requerido")]
		public int Id_marca { get; set; }

		[Required(ErrorMessage = "El id del concesionario es requerido")]
		public int Id_concesionario { get; set; }

	}
}
