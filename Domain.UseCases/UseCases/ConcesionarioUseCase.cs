using Domain.Entities.Entities;
using Domain.UseCases.Gateway;
using Domain.UseCases.Gateway.Repository;
using System;
using System.Collections.Generic;
using System.IO;
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

		public async Task<Concesionario> AgregarConcesionario(Concesionario concesionario)
		{
			return await _concesionarioRepository.InsertConcesionarioAsync(concesionario);
		}

		public async Task<Concesionario> ObtenerConcesionarioPorId(int idConcesionario)
		{
			return await _concesionarioRepository.GetConcesionarioByIdAsync(idConcesionario);
		}

		public async Task<IEnumerable<ConcesionarioConAuto>> ObtenerListaConcesionarios()
		{
			return await _concesionarioRepository.GetConcesionariosAsync();
		}
	}
}
