namespace Paraminter.Parameters;

internal interface IFixture
{
    public abstract IQueryHandler<IGetMethodParameterBySymbolQuery, IMethodParameter> Sut { get; }
}
