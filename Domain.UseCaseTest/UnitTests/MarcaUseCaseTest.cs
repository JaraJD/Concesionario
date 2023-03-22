using Domain.Entities.Commands;
using Domain.Entities.Entities;
using Domain.UseCases.Gateway.Repository;
using Domain.UseCaseTest.Builders;
using Moq;

namespace Domain.UseCaseTest.UnitTests
{
	public class MarcaUseCaseTest
	{
		private readonly Mock<IMarcaRepository<Marca>> _mockRepository;

		public MarcaUseCaseTest()
		{
			_mockRepository= new();
		}

		[Fact]
		public async Task Crear_marca()
		{
			//Arrange
			_mockRepository.Setup(repo => repo.AddAsync(It.IsAny<Marca>(), It.IsAny<CancellationToken>()))
				.ReturnsAsync(GetInsertMarca());

			//Act
			var useCase = new CertificadoUseCase(_mockRepository.Object);

			var res = await useCase.CrearCertificado(GetCertificadoCommand());

			//Assert
			_mockRepository.Verify(r => r.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()), Times.Exactly(4));

			_mockRepository.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));

			Assert.NotNull(res);
			Assert.IsType<CertificadoDTO>(res);
		}

		private InsertNewMarca GetInsertMarca() =>
			new InsertNewMarcaBuilder()
			.WithNombre("Audio")
			.Build();
	}
}
