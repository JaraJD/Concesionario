using Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases.Gateway.Repository
{
	public interface IConcesionarioRepository
	{
		Task<Concesionario> InsertConcesionarioAsync(Concesionario auto);

		Task<IEnumerable<Concesionario>> GetConcesionariosAsync();

		Task<Concesionario> GetConcesionarioByIdAsync(int idAuto);
	}
}
