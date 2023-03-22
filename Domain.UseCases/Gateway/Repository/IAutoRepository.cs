using Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases.Gateway.Repository
{
	public interface IAutoRepository
	{
		Task<Auto> InsertAutoAsync(Auto auto);

		Task<IEnumerable<AutoConMarca>> GetAutosAsync();

		Task<Auto> GetAutoByIdAsync(int idAuto);
	}
}
