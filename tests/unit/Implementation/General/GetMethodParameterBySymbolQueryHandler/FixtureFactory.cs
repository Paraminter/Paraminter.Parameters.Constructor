namespace Paraminter.Parameters;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        GetMethodParameterBySymbolQueryHandler sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IQueryHandler<IGetMethodParameterBySymbolQuery, IMethodParameter> Sut;

        public Fixture(
            IQueryHandler<IGetMethodParameterBySymbolQuery, IMethodParameter> sut)
        {
            Sut = sut;
        }

        IQueryHandler<IGetMethodParameterBySymbolQuery, IMethodParameter> IFixture.Sut => Sut;
    }
}
