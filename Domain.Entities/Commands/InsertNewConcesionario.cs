using Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Commands
{
	public class InsertNewConcesionario
	{
		public string Nombre_concesionario { get; set; }

		public int Cantidad_Disponible { get; set; }
	}
}
