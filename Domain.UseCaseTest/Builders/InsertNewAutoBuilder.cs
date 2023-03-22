using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCaseTest.Builders
{
	public class InsertNewAutoBuilder
	{
		public string Modelo { get; set; }

		public int Anio_fabricacion { get; set; }
		
		public int Id_marca { get; set; }

		public int Id_concesionario { get; set; }

		public InsertNewAutoBuilder WithModelo(string modelo)
		{
			Modelo = modelo;
			return this;
		}

		public InsertNewAutoBuilder WithAnioFabricacion(int anio)
		{
			Anio_fabricacion = anio;
			return this;
		}

		public InsertNewAutoBuilder WithIdMarca(int id)
		{
			Id_marca = id;
			return this;
		}

		public InsertNewAutoBuilder WithIdConcesionario(int id)
		{
			Id_concesionario = id;
			return this;
		}
	}
}
