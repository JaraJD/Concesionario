﻿using AutoMapper;
using Domain.Entities.Commands;
using Domain.Entities.Entities;
using Domain.UseCases.Gateway;
using Domain.UseCases.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace Concesionario.AppService.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AutoController
	{
		private readonly IAutoUseCase _autoUseCase;
		private readonly IMapper _mapper;

		public AutoController(IAutoUseCase autoUseCase, IMapper mapper)
		{
			_autoUseCase = autoUseCase;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<List<Auto>> Obtener_Listado_Autos()
		{
			return await _autoUseCase.ObtenerListaAutos();
		}

		[HttpGet("AutoId")]
		public async Task<Auto> Obtener_Auto(int id)
		{
			return await _autoUseCase.ObtenerAutoPorId(id);
		}

		[HttpPost]
		public async Task<Auto> Registrar_Marca([FromBody] InsertNewAuto command)
		{
			return await _autoUseCase.AgregarAuto(_mapper.Map<Auto>(command));
		}
	}
}
