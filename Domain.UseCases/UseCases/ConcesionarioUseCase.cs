using Domain.Entities.Entities;
using Domain.UseCases.Gateway;
using Domain.UseCases.Gateway.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases.UseCases
{
	public class ConcesionarioUseCase :  IConcesionarioUseCase
	{
		private readonly IConcesionarioRepository _concesionarioRepository;

		public ConcesionarioUseCase(IConcesionarioRepository concesionarioRepository)
		{
			_concesionarioRepository = concesionarioRepository;
		}

		public Task<Concesionario> AgregarConcesionario(Concesionario concesionario)
		{
			throw new NotImplementedException();
		}

		public Task<Concesionario> ObtenerConcesionarioPorId(int idConcesionario)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Concesionario>> ObtenerListaConcesionarios()
		{
			return await _concesionarioRepository.GetConcesionariosAsync();
		}
	}
}
