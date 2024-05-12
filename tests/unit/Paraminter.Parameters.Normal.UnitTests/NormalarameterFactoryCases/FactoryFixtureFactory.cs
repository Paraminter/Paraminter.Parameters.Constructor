namespace Paraminter.Parameters.NormalParameterFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        NormalParameterFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly INormalParameterFactory Sut;

        public FactoryFixture(INormalParameterFactory sut)
        {
            Sut = sut;
        }

        INormalParameterFactory IFactoryFixture.Sut => Sut;
    }
}
