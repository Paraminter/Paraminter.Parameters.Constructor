namespace Paraminter.Parameters;

using Microsoft.CodeAnalysis;

using System;

/// <inheritdoc cref="INormalParameterFactory"/>
public sealed class NormalParameterFactory : INormalParameterFactory
{
    /// <summary>Instantiates a <see cref="NormalParameterFactory"/>, handling creation of <see cref="INormalParameter"/>.</summary>
    public NormalParameterFactory() { }

    INormalParameter INormalParameterFactory.Create(IParameterSymbol symbol)
    {
        if (symbol is null)
        {
            throw new ArgumentNullException(nameof(symbol));
        }

        return new NormalParameter(symbol);
    }

    private sealed class NormalParameter : INormalParameter
    {
        private readonly IParameterSymbol Symbol;

        public NormalParameter(IParameterSymbol symbol)
        {
            Symbol = symbol;
        }

        IParameterSymbol INormalParameter.Symbol => Symbol;
    }
}
