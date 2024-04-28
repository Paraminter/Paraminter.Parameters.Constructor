namespace Attribinter.Parameters.ConstructorParameterFactoryCases.ConstructorParameterCases;

using Microsoft.CodeAnalysis;

using Moq;

internal interface IParameterFixture
{
    public abstract IConstructorParameter Sut { get; }

    public abstract Mock<IParameterSymbol> SymbolMock { get; }
}
