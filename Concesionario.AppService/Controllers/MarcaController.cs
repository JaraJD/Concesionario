using AutoMapper;
using Domain.Entities.Commands;
using Domain.Entities.Entities;
using Domain.UseCases.Gateway;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Concesionario.AppService.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class MarcaController :  ControllerBase
	{
		private readonly IMarcaUseCase _marcaUseCase;
		private readonly IMapper _mapper;

		public MarcaController(IMarcaUseCase marcaUseCase, IMapper mapper)
		{
			_marcaUseCase = marcaUseCase;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<List<Marca>> Obtener_Listado_Marcas()
		{
			return await _marcaUseCase.ObtenerListaMarcas();
		}

		[HttpPost]
		public async Task<Marca> Registrar_Marca([FromBody] InsertNewMarca command)
		{
			return await _marcaUseCase.AgregarMarca(_mapper.Map<Marca>(command));
		}
	}
}
