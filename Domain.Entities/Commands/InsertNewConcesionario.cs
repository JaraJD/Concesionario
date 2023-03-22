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
		[Required]
		public string Nombre_concesionario { get; set; }

		[Required]
		public int Cantidad_Disponible { get; set; }

	}
}
