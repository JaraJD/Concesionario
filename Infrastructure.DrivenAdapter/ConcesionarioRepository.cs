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
	public class ConcesionarioRepository :  IConcesionarioRepository
	{
		private readonly IDbConnectionBuilder _dbConnectionBuilder;
		private readonly string tableName = "concesionario";

		public ConcesionarioRepository(IDbConnectionBuilder dbConnectionBuilder)
		{
			_dbConnectionBuilder = dbConnectionBuilder;
		}

		public async Task<Concesionario> GetConcesionarioByIdAsync(int idConcesionario)
		{
			var connection = await _dbConnectionBuilder.CreateConnectionAsync();
			string sqlQuery = $"SELECT * FROM {tableName} WHERE id = @idConcesionario";
			var result = await connection.QuerySingleAsync<Concesionario>(sqlQuery, new { idConcesionario });
			connection.Close();
			return result;
		}

		public async Task<List<Concesionario>> GetConcesionariosAsync()
		{
			var connection = await _dbConnectionBuilder.CreateConnectionAsync();
			string sqlQuery = $"SELECT * FROM {tableName}";
			
			var result = await connection.QueryAsync<Concesionario>(sqlQuery);
			connection.Close();
			return result.ToList();
		}

		public async Task<Concesionario> InsertConcesionarioAsync(Concesionario concesionario)
		{
			var connection = await _dbConnectionBuilder.CreateConnectionAsync();
			var concesionarioAgregar = new
			{
				nombre = concesionario.Nombre_concesionario,
				cantidad = concesionario.Cantidad_Disponible,
			};
			string sqlQuery = $"INSERT INTO {tableName} (nombre_concesionario, cantidad_disponible)VALUES(@nombre, @cantidad)";
			var rows = await connection.ExecuteAsync(sqlQuery, concesionarioAgregar);
			return concesionario;
		}
	}
}
