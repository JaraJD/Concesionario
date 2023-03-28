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
	public class MarcaUseCase : IMarcaUseCase
	{

		private readonly IMarcaRepository _marcaRepository;

		public MarcaUseCase(IMarcaRepository marcaRepository) 
		{
			_marcaRepository = marcaRepository;
		}

		public async Task<Marca> ActualizarMarca(string idMarca, Marca marca)
		{
			return await _marcaRepository.PutMarcaAsync(idMarca, marca);
		}

		public async Task<Marca> AgregarMarca(Marca marca)
		{
			return await _marcaRepository.InsertMarcaAsync(marca);
		}

		public Task<Marca> BorrarMarca(int idMarca)
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
