namespace Paraminter.Parameters.ConstructorParameterFactoryCases.ConstructorParameterCases;

using Microsoft.CodeAnalysis;

using Moq;

internal static class ParameterFixtureFactory
{
    public static IParameterFixture Create()
    {
        Mock<IParameterSymbol> symbolMock = new();

        IConstructorParameterFactory factory = new ConstructorParameterFactory();

        var sut = factory.Create(symbolMock.Object);

        return new ParameterFixture(sut, symbolMock);
    }

    private sealed class ParameterFixture : IParameterFixture
    {
        private readonly IConstructorParameter Sut;

        private readonly Mock<IParameterSymbol> SymbolMock;

        public ParameterFixture(IConstructorParameter sut, Mock<IParameterSymbol> symbolMock)
        {
            Sut = sut;

            SymbolMock = symbolMock;
        }

        IConstructorParameter IParameterFixture.Sut => Sut;

        Mock<IParameterSymbol> IParameterFixture.SymbolMock => SymbolMock;
    }
}
