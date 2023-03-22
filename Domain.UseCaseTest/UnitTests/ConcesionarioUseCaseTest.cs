using Domain.Entities.Entities;
using Domain.UseCases.Gateway.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCaseTest.UnitTests
{
	public class ConcesionarioUseCaseTest
	{
		private readonly Mock<IConcesionarioRepository> _mockRepository;

		public ConcesionarioUseCaseTest()
		{
			_mockRepository = new();
		}

		[Fact]
		public async Task Crear_Concesionario()
		{
			//Arrange

			var insertarConcesionario = new Concesionario
			{
				Nombre_concesionario = "Tu Carro",
				Cantidad_Disponible = 12
			};

			var concesionario = new Concesionario
			{
				Nombre_concesionario = "Tu Carro",
				Cantidad_Disponible = 12
			};

			_mockRepository.Setup(repo => repo.InsertConcesionarioAsync(insertarConcesionario))
				.ReturnsAsync(concesionario);

			//Act

			var res = await _mockRepository.Object.InsertConcesionarioAsync(insertarConcesionario);

			//Assert
			Assert.Equal(concesionario, res);
		}
	}
}
