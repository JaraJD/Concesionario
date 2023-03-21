using Dapper;
using Domain.Entities.Entities;
using Domain.UseCases.Gateway.Repository;
using Infrastructure.DrivenAdapter.Gateway;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DrivenAdapter
{
	public class MarcaRepository : IMarcaRepository
	{
		private readonly IDbConnectionBuilder _dbConnectionBuilder;
		private readonly string tableName = "marcas";

		public MarcaRepository(IDbConnectionBuilder dbConnectionBuilder)
		{
			_dbConnectionBuilder = dbConnectionBuilder;
		}

		public async Task<List<Marca>> GetAllMarcasAsync()
		{
			var connection = await _dbConnectionBuilder.CreateConnectionAsync();
			string sqlQuery = $"SELECT * FROM {tableName}";
			var result = await connection.QueryAsync<Marca>(sqlQuery);
			connection.Close();
			return result.ToList();
		}

		public Task<Marca> GetMarcaByIdAsync(int idMarca)
		{
			throw new NotImplementedException();
		}

		public async Task<Marca> InsertMarcaAsync(Marca marca)
		{
			var connection = await _dbConnectionBuilder.CreateConnectionAsync();
			var marcaAgregar = new
			{
				nombre = marca.Nombre_marca
			};
			string sqlQuery = $"INSERT INTO {tableName} (nombre_marca)VALUES(@nombre)";
			var rows = await connection.ExecuteAsync(sqlQuery, marcaAgregar);
			return marca;
		}
	}
}
