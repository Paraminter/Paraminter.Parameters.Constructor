namespace Attribinter.Parameters.ConstructorParameterFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        ConstructorParameterFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly IConstructorParameterFactory Sut;

        public FactoryFixture(IConstructorParameterFactory sut)
        {
            Sut = sut;
        }

        IConstructorParameterFactory IFactoryFixture.Sut => Sut;
    }
}
