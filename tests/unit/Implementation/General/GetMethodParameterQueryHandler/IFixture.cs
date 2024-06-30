namespace Paraminter.Parameters;

internal interface IFixture
{
    public abstract IQueryHandler<IGetMethodParameterQuery, IMethodParameter> Sut { get; }
}
