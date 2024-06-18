namespace Paraminter.Parameters;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        MethodParameterFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IMethodParameterFactory Sut;

        public Fixture(
            IMethodParameterFactory sut)
        {
            Sut = sut;
        }

        IMethodParameterFactory IFixture.Sut => Sut;
    }
}
