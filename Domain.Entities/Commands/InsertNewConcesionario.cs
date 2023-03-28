using Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Commands
{
	public class InsertNewConcesionario
	{
		[Required(ErrorMessage = "Nombre del concesionario es requerido")]
		public string Nombre_concesionario { get; set; }

		[Required(ErrorMessage = "La cantidad de autos es requerida")]
		public int Cantidad_Disponible { get; set; }

	}
}
