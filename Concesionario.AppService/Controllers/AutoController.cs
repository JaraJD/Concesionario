using AutoMapper;
using Domain.Entities.Entities;
using Domain.UseCases.Gateway;
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
	}
}
