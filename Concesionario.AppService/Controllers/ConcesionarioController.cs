using AutoMapper;
using Domain.UseCases.Gateway;
using Microsoft.AspNetCore.Mvc;

namespace Concesionario.AppService.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ConcesionarioController
	{
		private readonly IConcesionarioUseCase _concesionarioUseCase;
		private readonly IMapper _mapper;

		public ConcesionarioController(IConcesionarioUseCase concesionarioUseCase, IMapper mapper)
		{
			_concesionarioUseCase = concesionarioUseCase;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<List<Domain.Entities.Entities.Concesionario>> Obtener_Listado_Concesionarios()
		{
			return await _concesionarioUseCase.ObtenerListaConcesionarios();
		}

		[HttpGet("ConcesionarioId")]
		public async Task<Domain.Entities.Entities.Concesionario> Obtener_Concesionario(int id)
		{
			return await _concesionarioUseCase.ObtenerConcesionarioPorId(id);
		}
	}
}
