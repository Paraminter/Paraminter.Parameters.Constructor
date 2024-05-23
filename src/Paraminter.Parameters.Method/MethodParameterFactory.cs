namespace Paraminter.Parameters;

using Microsoft.CodeAnalysis;

using System;

/// <inheritdoc cref="IMethodParameterFactory"/>
public sealed class MethodParameterFactory : IMethodParameterFactory
{
    /// <summary>Instantiates a <see cref="MethodParameterFactory"/>, handling creation of <see cref="IMethodParameter"/>.</summary>
    public MethodParameterFactory() { }

    IMethodParameter IMethodParameterFactory.Create(IParameterSymbol symbol)
    {
        if (symbol is null)
        {
            throw new ArgumentNullException(nameof(symbol));
        }

        return new MethodParameter(symbol);
    }

    private sealed class MethodParameter : IMethodParameter
    {
        private readonly IParameterSymbol Symbol;

        public MethodParameter(IParameterSymbol symbol)
        {
            Symbol = symbol;
        }

        IParameterSymbol IMethodParameter.Symbol => Symbol;
    }
}
