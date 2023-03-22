using Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;
using Domain.Entities.Commands;

namespace Domain.UseCases.Gateway.Repository
{
	public interface IMarcaRepository
	{
		Task<Marca> InsertMarcaAsync(Marca marca);

		Task<List<Marca>> GetAllMarcasAsync();

		Task<Marca> GetMarcaByIdAsync(int idMarca);
	}
}
