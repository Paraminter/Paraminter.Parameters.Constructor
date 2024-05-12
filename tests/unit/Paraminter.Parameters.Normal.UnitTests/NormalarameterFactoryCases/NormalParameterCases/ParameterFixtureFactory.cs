namespace Paraminter.Parameters.NormalParameterFactoryCases.NormalParameterCases;

using Microsoft.CodeAnalysis;

using Moq;

internal static class ParameterFixtureFactory
{
    public static IParameterFixture Create()
    {
        Mock<IParameterSymbol> symbolMock = new();

        INormalParameterFactory factory = new NormalParameterFactory();

        var sut = factory.Create(symbolMock.Object);

        return new ParameterFixture(sut, symbolMock);
    }

    private sealed class ParameterFixture : IParameterFixture
    {
        private readonly INormalParameter Sut;

        private readonly Mock<IParameterSymbol> SymbolMock;

        public ParameterFixture(INormalParameter sut, Mock<IParameterSymbol> symbolMock)
        {
            Sut = sut;

            SymbolMock = symbolMock;
        }

        INormalParameter IParameterFixture.Sut => Sut;

        Mock<IParameterSymbol> IParameterFixture.SymbolMock => SymbolMock;
    }
}
