using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Commands
{
	public class InsertNewAuto
	{
		public string modelo { get; set; }

		public int Anio_fabricacion { get; set; }

		public int Id_marca { get; set; }

		public int Id_concesionario { get; set; }
	}
}
