namespace Paraminter.Parameters.MethodParameterFactoryCases.MethodParameterCases;

using Microsoft.CodeAnalysis;

using Moq;

internal static class ParameterFixtureFactory
{
    public static IParameterFixture Create()
    {
        Mock<IParameterSymbol> symbolMock = new();

        IMethodParameterFactory factory = new MethodParameterFactory();

        var sut = factory.Create(symbolMock.Object);

        return new ParameterFixture(sut, symbolMock);
    }

    private sealed class ParameterFixture : IParameterFixture
    {
        private readonly IMethodParameter Sut;

        private readonly Mock<IParameterSymbol> SymbolMock;

        public ParameterFixture(IMethodParameter sut, Mock<IParameterSymbol> symbolMock)
        {
            Sut = sut;

            SymbolMock = symbolMock;
        }

        IMethodParameter IParameterFixture.Sut => Sut;

        Mock<IParameterSymbol> IParameterFixture.SymbolMock => SymbolMock;
    }
}
