namespace Paraminter.Parameters.ConstructorParameterFactoryCases.ConstructorParameterCases;

using Microsoft.CodeAnalysis;

using Xunit;

public sealed class Symbol
{
    private IParameterSymbol Target() => Fixture.Sut.Symbol;

    private readonly IParameterFixture Fixture = ParameterFixtureFactory.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var result = Target();

        Assert.Same(Fixture.SymbolMock.Object, result);
    }
}
