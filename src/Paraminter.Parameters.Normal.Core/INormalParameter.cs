namespace Paraminter.Parameters;

using Microsoft.CodeAnalysis;

/// <summary>Represents a normal parameter.</summary>
public interface INormalParameter
{
    /// <summary>The symbol associated with the normal parameter.</summary>
    public abstract IParameterSymbol Symbol { get; }
}
