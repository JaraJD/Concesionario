using AutoMapper;
using Domain.Entities.Entities;
using Domain.UseCases.Gateway.Repository;
using Mongo.DrivenAdapter.EntitiesMongo;
using Mongo.DrivenAdapter.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.DrivenAdapter.Repositories
{
	public class MarcaRepository : IMarcaRepository
	{
		private readonly IMongoCollection<MarcaEntitie> mongoCollection;
		private readonly IMapper _mapper;

		public MarcaRepository(IContext context, IMapper mapper)
		{
			mongoCollection = context.Marcas;
			_mapper = mapper;
		}

		public Task<Marca> DeleteMarcaAsync(int idMarca)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Marca>> GetAllMarcasAsync()
		{
			var marcas = await mongoCollection.FindAsync(Builders<MarcaEntitie>.Filter.Empty);
			var listaMarcas = marcas.ToEnumerable().Select(marca => _mapper.Map<Marca>(marca)).ToList();
			return listaMarcas;
		}

		public Task<Marca> GetMarcaByIdAsync(int idMarca)
		{
			throw new NotImplementedException();
		}

		public async Task<Marca> InsertMarcaAsync(Marca marca)
		{
			var insertMarca = _mapper.Map<MarcaEntitie>(marca);
			await mongoCollection.InsertOneAsync(insertMarca);
			return marca;
		}

		public async Task<Marca> PutMarcaAsync(string idMarca, Marca marca)
		{
			var insertMarca = _mapper.Map<MarcaEntitie>(marca);
			var filter = Builders<MarcaEntitie>.Filter.Eq(m => m.Id_Mongo, idMarca);
			var marcaToUpdate = await mongoCollection.Find(filter).FirstOrDefaultAsync();

			if (marcaToUpdate == null)
			{
				throw new Exception($"Marca con id {idMarca} no encontrada.");
			}

			//var updateResult = await mongoCollection.ReplaceOneAsync(filter, insertMarca);

			//if (updateResult.ModifiedCount == 0)
			//{
			//	throw new Exception($"No se pudo actualizar la marca con id {idMarca}.");
			//}

			return marca;
		}
	}
}
