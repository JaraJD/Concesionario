using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Entities
{
	public class Marca
	{
		public int Id { get; set; }

		public string Nombre_marca { get; set; }

		public Marca(int id, string nombre_marca)
		{
			Id = id;
			Nombre_marca = nombre_marca;
		}

		public Marca()
		{

		}
	}
}
