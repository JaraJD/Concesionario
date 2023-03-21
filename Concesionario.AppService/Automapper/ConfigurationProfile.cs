using AutoMapper;
using Domain.Entities.Commands;
using Domain.Entities.Entities;

namespace Concesionario.AppService.Automapper
{
	public class ConfigurationProfile :  Profile
	{
		public ConfigurationProfile()
		{
			CreateMap<InsertNewMarca, Marca>().ReverseMap();
			CreateMap<InsertNewConcesionario, Domain.Entities.Entities.Concesionario>().ReverseMap();
			CreateMap<InsertNewAuto, Auto>().ReverseMap();
		}
	}
}
