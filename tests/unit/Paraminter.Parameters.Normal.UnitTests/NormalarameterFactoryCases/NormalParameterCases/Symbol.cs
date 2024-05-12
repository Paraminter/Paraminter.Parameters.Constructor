namespace Paraminter.Parameters.NormalParameterFactoryCases.NormalParameterCases;

using Microsoft.CodeAnalysis;

using Xunit;

public sealed class Symbol
{
    private readonly IParameterFixture Fixture = ParameterFixtureFactory.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var result = Target();

        Assert.Same(Fixture.SymbolMock.Object, result);
    }

    private IParameterSymbol Target() => Fixture.Sut.Symbol;
}
