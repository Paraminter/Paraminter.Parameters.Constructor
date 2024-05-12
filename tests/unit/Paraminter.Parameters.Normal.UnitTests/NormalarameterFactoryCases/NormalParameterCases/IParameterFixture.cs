namespace Paraminter.Parameters.NormalParameterFactoryCases.NormalParameterCases;

using Microsoft.CodeAnalysis;

using Moq;

internal interface IParameterFixture
{
    public abstract INormalParameter Sut { get; }

    public abstract Mock<IParameterSymbol> SymbolMock { get; }
}
