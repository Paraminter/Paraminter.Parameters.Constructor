namespace Paraminter.Parameters.MethodParameter;

using Microsoft.CodeAnalysis;

using Xunit;

public sealed class Symbol
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void ReturnsSymbol()
    {
        var result = Target();

        Assert.Same(Fixture.SymbolMock.Object, result);
    }

    private IParameterSymbol Target() => Fixture.Sut.Symbol;
}
