namespace Paraminter.Parameters.MethodParameter;

using Microsoft.CodeAnalysis;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<IParameterSymbol> symbolMock = new();

        Mock<IGetMethodParameterBySymbolQuery> queryMock = new();

        queryMock.Setup(static (query) => query.Symbol).Returns(symbolMock.Object);

        IQueryHandler<IGetMethodParameterBySymbolQuery, IMethodParameter> factory = new GetMethodParameterBySymbolQueryHandler();

        var sut = factory.Handle(queryMock.Object);

        return new Fixture(sut, symbolMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IMethodParameter Sut;

        private readonly Mock<IParameterSymbol> SymbolMock;

        public Fixture(
            IMethodParameter sut,
            Mock<IParameterSymbol> symbolMock)
        {
            Sut = sut;

            SymbolMock = symbolMock;
        }

        IMethodParameter IFixture.Sut => Sut;

        Mock<IParameterSymbol> IFixture.SymbolMock => SymbolMock;
    }
}
