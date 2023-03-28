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

		public async Task<IEnumerable<ConcesionarioConAuto>> GetConcesionariosAsync()
		{
			var connection = await _dbConnectionBuilder.CreateConnectionAsync();

			var sql = $"SELECT * FROM {tableName} C " +
					  $"INNER JOIN auto A ON C.id=A.id_concesionario " +
					  $"INNER JOIN marcas M ON A.id_marca = M.id";
			var concesionario = await connection.QueryAsync<ConcesionarioConAuto, AutoConMarca, Marca, ConcesionarioConAuto>(sql,
			(concesionario, auto, marca) => {
				if (concesionario.Autos == null)
				{
					concesionario.Autos = new List<AutoConMarca>();
				}
				auto.marca = marca;
				concesionario.Autos.Add(auto);
				return concesionario;
			},
			splitOn: "id");

			connection.Close();
			return concesionario;
		}

		public async Task<Concesionario> InsertConcesionarioAsync(Concesionario concesionario)
		{
			if (concesionario.Nombre_concesionario == "" || concesionario.Cantidad_Disponible < 0)
			{
				throw new Exception("Campos erroneos porfavor verifica los datos ingresados");
			}
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
