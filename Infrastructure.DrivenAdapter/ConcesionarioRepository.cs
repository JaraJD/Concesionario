using Dapper;
using Domain.Entities.Entities;
using Domain.UseCases.Gateway.Repository;
using Infrastructure.DrivenAdapter.Gateway;
using System;
using System.Collections.Generic;
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

		public Task<Concesionario> GetConcesionarioByIdAsync(int idAuto)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Concesionario>> GetConcesionariosAsync()
		{
			var connection = await _dbConnectionBuilder.CreateConnectionAsync();
			string sqlQuery = $"SELECT * FROM {tableName}";
			var result = await connection.QueryAsync<Concesionario>(sqlQuery);
			connection.Close();
			return result.ToList();
		}

		public Task<Concesionario> InsertConcesionarioAsync(Concesionario auto)
		{
			throw new NotImplementedException();
		}
	}
}
