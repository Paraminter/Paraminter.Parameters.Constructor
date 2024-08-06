namespace Paraminter.Parameters.Method.Models;

using Microsoft.CodeAnalysis;

using Paraminter.Associators.Models;

/// <summary>Represents a method parameter.</summary>
public interface IMethodParameter
    : IParameter
{
    /// <summary>The symbol associated with the method parameter.</summary>
    public abstract IParameterSymbol Symbol { get; }
}
