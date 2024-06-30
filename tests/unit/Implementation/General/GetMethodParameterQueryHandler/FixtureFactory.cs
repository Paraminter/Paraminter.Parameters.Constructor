namespace Paraminter.Parameters;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        GetMethodParameterQueryHandler sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IQueryHandler<IGetMethodParameterQuery, IMethodParameter> Sut;

        public Fixture(
            IQueryHandler<IGetMethodParameterQuery, IMethodParameter> sut)
        {
            Sut = sut;
        }

        IQueryHandler<IGetMethodParameterQuery, IMethodParameter> IFixture.Sut => Sut;
    }
}
