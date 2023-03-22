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
		public async Task Crear_Auto()
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

		[Fact]
		public async Task Get_Autos()
		{
			//arrange
			List<AutoConMarca> Autos = new();
			var test = new AutoConMarca
			{
				modelo = "Audi A1",
				Anio_fabricacion = 2022
			};
			var test1 = new AutoConMarca
			{
				modelo = "Audi A3",
				Anio_fabricacion = 2023
			};
			Autos.Add(test);
			Autos.Add(test1);
			_mockRepository.Setup(x => x.GetAutosAsync()).ReturnsAsync(Autos);
			//act
			var result = await _mockRepository.Object.GetAutosAsync();
			//assert
			Assert.Equal(Autos, result);
		}
	}
}
