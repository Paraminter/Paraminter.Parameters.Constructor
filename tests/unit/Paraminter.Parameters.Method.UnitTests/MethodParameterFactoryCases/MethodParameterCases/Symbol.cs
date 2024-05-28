namespace Paraminter.Parameters.MethodParameterFactoryCases.MethodParameterCases;

using Microsoft.CodeAnalysis;

using Xunit;

public sealed class Symbol
{
    private readonly IParameterFixture Fixture = ParameterFixtureFactory.Create();

    [Fact]
    public void ReturnsSymbol()
    {
        var result = Target();

        Assert.Same(Fixture.SymbolMock.Object, result);
    }

    private IParameterSymbol Target() => Fixture.Sut.Symbol;
}
