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
	public class AutoRepository : IAutoRepository
	{
		private readonly IDbConnectionBuilder _dbConnectionBuilder;
		private readonly string tableName = "auto";

		public AutoRepository(IDbConnectionBuilder dbConnectionBuilder)
		{
			_dbConnectionBuilder = dbConnectionBuilder;
		}

		public Task<Auto> GetAutoByIdAsync(int idAuto)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Auto>> GetAutosAsync()
		{
			var connection = await _dbConnectionBuilder.CreateConnectionAsync();
			string sqlQuery = $"SELECT * FROM {tableName}";
			var result = await connection.QueryAsync<Auto>(sqlQuery);
			connection.Close();
			return result.ToList();
		}

		public Task<Auto> InsertAutoAsync(Auto auto)
		{
			throw new NotImplementedException();
		}
	}
}
