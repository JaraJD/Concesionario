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
	public class AutoUseCase : IAutoUseCase
	{
		private readonly IAutoRepository _autoRepository;

		public AutoUseCase(IAutoRepository autoRepository)
		{
			_autoRepository = autoRepository;
		}

		public Task<Auto> AgregarAuto(Auto auto)
		{
			throw new NotImplementedException();
		}

		public Task<Auto> ObtenerAutoPorId(int idAuto)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Auto>> ObtenerListaAutos()
		{
			return await _autoRepository.GetAutosAsync();
		}
	}
}
