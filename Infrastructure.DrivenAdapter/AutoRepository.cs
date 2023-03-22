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

		public async Task<IEnumerable<AutoConMarca>> GetAutosAsync()
		{
			var connection = await _dbConnectionBuilder.CreateConnectionAsync();

			var sql = $"SELECT * FROM {tableName} A INNER JOIN marcas M ON A.id_marca=M.id";
			var auto = await connection.QueryAsync<AutoConMarca, Marca, AutoConMarca>(sql,
			(auto, marca) => {
				auto.marca = marca;
				return auto;
			},
			splitOn: "id_marca");

			connection.Close();
			return auto;
		}

		public async Task<Auto> InsertAutoAsync(Auto auto)
		{
			var connection = await _dbConnectionBuilder.CreateConnectionAsync();
			var autoAgregar = new
			{
				modelo = auto.modelo,
				anio = auto.Anio_fabricacion,
				marcaId = auto.Id_marca,
				concesionarioId = auto.Id_concesionario,
			};
			string sqlQuery = $"INSERT INTO {tableName} (modelo, anio_fabricacion, id_marca, id_concesionario)VALUES(@modelo, @anio, @marcaId, @concesionarioId)";
			var rows = await connection.ExecuteAsync(sqlQuery, autoAgregar);
			return auto;
		}
	}
}
