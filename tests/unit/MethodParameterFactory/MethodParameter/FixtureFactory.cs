namespace Paraminter.Parameters.MethodParameter;

using Microsoft.CodeAnalysis;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<IParameterSymbol> symbolMock = new();

        IMethodParameterFactory factory = new MethodParameterFactory();

        var sut = factory.Create(symbolMock.Object);

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
