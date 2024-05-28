namespace Paraminter.Parameters.MethodParameterFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        MethodParameterFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture
        : IFactoryFixture
    {
        private readonly IMethodParameterFactory Sut;

        public FactoryFixture(
            IMethodParameterFactory sut)
        {
            Sut = sut;
        }

        IMethodParameterFactory IFactoryFixture.Sut => Sut;
    }
}
