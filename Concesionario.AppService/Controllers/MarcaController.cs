using AutoMapper;
using Domain.Entities.Entities;
using Domain.UseCases.Gateway;
using Microsoft.AspNetCore.Mvc;

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

		[HttpGet("MarcaId")]
		public async Task<Marca> Obtener_Marca(int id)
		{
			return await _marcaUseCase.ObtenerMarcaPorId(id);
		}
	}
}
