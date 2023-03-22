using Domain.Entities.Commands;
using Domain.Entities.Entities;
using Domain.UseCases.Gateway.Repository;
using Moq;

namespace Domain.UseCaseTest.UnitTests
{
	public class MarcaUseCaseTest
	{
		private readonly Mock<IMarcaRepository> _mockRepository;

		public MarcaUseCaseTest()
		{
			_mockRepository= new();
		}

		[Fact]
		public async Task Crear_marca()
		{
			//Arrange

			var insertarMarca = new Marca
			{
				Nombre_marca = "Audi"
			};

			var marca = new Marca
			{
				Nombre_marca = "Audi"
			};

			_mockRepository.Setup(repo => repo.InsertMarcaAsync(insertarMarca))
				.ReturnsAsync(marca);

			//Act

			var res = await _mockRepository.Object.InsertMarcaAsync(insertarMarca);

			//Assert
			Assert.Equal(marca, res);
		}

	}
}
