namespace Paraminter.Parameters;

using Microsoft.CodeAnalysis;

/// <summary>Handles creation of <see cref="INormalParameter"/>.</summary>
public interface INormalParameterFactory
{
    /// <summary>Creates a <see cref="INormalParameter"/>, representing a normal parameter.</summary>
    /// <param name="symbol">The symbol associated with the parameter.</param>
    /// <returns>The created <see cref="INormalParameter"/>.</returns>
    public abstract INormalParameter Create(IParameterSymbol symbol);
}
