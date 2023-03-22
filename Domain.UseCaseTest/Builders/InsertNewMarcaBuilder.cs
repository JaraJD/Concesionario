using Domain.Entities.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCaseTest.Builders
{
	public class InsertNewMarcaBuilder
	{
		public string Nombre_marca { get; set; }

		public InsertNewMarcaBuilder WithNombre(string nombre_marca)
		{
			Nombre_marca = nombre_marca;
			return this;
		}

		public InsertNewMarca Build()
		{
			return new InsertNewMarca(Nombre_marca);
		}
	}
}
