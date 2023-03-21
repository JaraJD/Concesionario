using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Entities
{
	public class ConcesionarioConAuto
	{
		public int Id { get; set; }

		public string Nombre_concesionario { get; set; }

		public int Cantidad_Disponible { get; set; }

		public List<Auto> Autos { get; set; }
	}
}
