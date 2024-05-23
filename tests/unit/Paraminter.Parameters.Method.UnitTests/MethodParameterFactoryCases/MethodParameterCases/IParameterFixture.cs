namespace Paraminter.Parameters.MethodParameterFactoryCases.MethodParameterCases;

using Microsoft.CodeAnalysis;

using Moq;

internal interface IParameterFixture
{
    public abstract IMethodParameter Sut { get; }

    public abstract Mock<IParameterSymbol> SymbolMock { get; }
}
