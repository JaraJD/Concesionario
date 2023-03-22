using Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases.Gateway
{
	public interface IAutoUseCase
	{
		Task<Auto> AgregarAuto(Auto auto);

		Task<IEnumerable<AutoConMarca>> ObtenerListaAutos();

		Task<Auto> ObtenerAutoPorId(int idAuto);
	}
}
