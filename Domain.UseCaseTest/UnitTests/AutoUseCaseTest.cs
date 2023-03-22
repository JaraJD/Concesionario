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
	public class AutoUseCaseTest
	{
		private readonly Mock<IAutoRepository> _mockRepository;

		public AutoUseCaseTest()
		{
			_mockRepository = new();
		}

		[Fact]
		public async Task Crear_Concesionario()
		{
			//Arrange

			var insertarAuto = new Auto
			{
				modelo = "Audi A1",
				Anio_fabricacion = 2022,
				Id_marca = 1,
				Id_concesionario = 2
			};

			var auto = new Auto
			{
				modelo = "Audi A1",
				Anio_fabricacion = 2022,
				Id_marca = 1,
				Id_concesionario = 2
			};

			_mockRepository.Setup(repo => repo.InsertAutoAsync(insertarAuto))
				.ReturnsAsync(auto);

			//Act

			var res = await _mockRepository.Object.InsertAutoAsync(insertarAuto);

			//Assert
			Assert.Equal(auto, res);
		}
	}
}
