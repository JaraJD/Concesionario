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

		[Fact]
		public async Task Get_Marcas()
		{
			//arrange
			List<Marca> Marca = new();
			var chevrolet = new Marca
			{
				Nombre_marca = "Chevrolet"
			};
			var ford = new Marca
			{
				Nombre_marca = "Ford"
			};
			Marca.Add(chevrolet);
			Marca.Add(ford);
			_mockRepository.Setup(x => x.GetAllMarcasAsync()).ReturnsAsync(Marca);
			//act
			var result = await _mockRepository.Object.GetAllMarcasAsync();
			//assert
			Assert.Equal(Marca, result);
		}

	}
}
