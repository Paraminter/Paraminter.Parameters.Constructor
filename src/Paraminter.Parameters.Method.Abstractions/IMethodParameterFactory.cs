namespace Paraminter.Parameters;

using Microsoft.CodeAnalysis;

/// <summary>Handles creation of <see cref="IMethodParameter"/>.</summary>
public interface IMethodParameterFactory
{
    /// <summary>Creates a <see cref="IMethodParameter"/>, representing a method parameter.</summary>
    /// <param name="symbol">The symbol associated with the parameter.</param>
    /// <returns>The created <see cref="IMethodParameter"/>.</returns>
    public abstract IMethodParameter Create(
        IParameterSymbol symbol);
}
