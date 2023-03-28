using Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases.Gateway
{
	public interface IConcesionarioUseCase
	{
		Task<Concesionario> AgregarConcesionario(Concesionario concesionario);

		Task<IEnumerable<ConcesionarioConAuto>> ObtenerListaConcesionarios();

		Task<Concesionario> ObtenerConcesionarioPorId(int idConcesionario);
	}
}
