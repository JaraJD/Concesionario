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
	public class MarcaUseCase : IMarcaUseCase
	{

		private readonly IMarcaRepository _marcaRepository;

		public MarcaUseCase(IMarcaRepository marcaRepository) 
		{
			_marcaRepository = marcaRepository;
		}

		public Task<Marca> AgregarMarca(Marca marca)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Marca>> ObtenerListaMarcas()
		{
			return await _marcaRepository.GetAllMarcasAsync();
		}

		public Task<Marca> ObtenerMarcaPorId(int idMarca)
		{
			throw new NotImplementedException();
		}
	}
}
