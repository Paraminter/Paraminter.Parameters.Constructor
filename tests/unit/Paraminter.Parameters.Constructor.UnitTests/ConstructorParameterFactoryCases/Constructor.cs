namespace Paraminter.Parameters.ConstructorParameterFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static ConstructorParameterFactory Target() => new();
}
