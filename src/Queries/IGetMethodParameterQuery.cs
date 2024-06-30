namespace Paraminter.Parameters;

using Microsoft.CodeAnalysis;

/// <summary>Represents a query for a method parameter.</summary>
public interface IGetMethodParameterQuery
    : IQuery
{
    /// <summary>The symbol associated with the method parameter.</summary>
    public abstract IParameterSymbol Symbol { get; }
}
