using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCaseTest.Builders
{
	public class InsertNewConcesionarioBuilder
	{
		public string Nombre_concesionario { get; set; }

		public int Cantidad_Disponible { get; set; }

		public InsertNewConcesionarioBuilder WithNombre(string nombre_concesionario)
		{
			Nombre_concesionario = nombre_concesionario;
			return this;
		}

		public InsertNewConcesionarioBuilder WithCantidad(int cantidad_Disponible)
		{
			Cantidad_Disponible = cantidad_Disponible;
			return this;
		}
	}
}
