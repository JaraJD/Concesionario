using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Entities
{
	public class AutoConMarca
	{
		public int Id { get; set; }

		public string modelo { get; set; }

		public int Anio_fabricacion { get; set; }

		public Marca marca { get; set; }
	}
}
