﻿using Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases.Gateway
{
	public interface IMarcaUseCase
	{
		Task<Marca> AgregarMarca(Marca marca);

		Task<List<Marca>> ObtenerListaMarcas();

		Task<Marca> ObtenerMarcaPorId(int idMarca);

		Task<Marca> ActualizarMarca(string idMarca, Marca marca);

		Task<Marca> BorrarMarca(int idMarca);
	}
}
