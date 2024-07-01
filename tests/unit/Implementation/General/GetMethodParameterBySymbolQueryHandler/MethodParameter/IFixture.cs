namespace Paraminter.Parameters.MethodParameter;

using Microsoft.CodeAnalysis;

using Moq;

internal interface IFixture
{
    public abstract IMethodParameter Sut { get; }

    public abstract Mock<IParameterSymbol> SymbolMock { get; }
}
