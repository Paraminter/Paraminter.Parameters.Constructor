namespace Paraminter.Parameters.Method.Models;

using Microsoft.CodeAnalysis;

/// <summary>Represents a method parameter.</summary>
public interface IMethodParameter
{
    /// <summary>The symbol associated with the method parameter.</summary>
    public abstract IParameterSymbol Symbol { get; }
}
