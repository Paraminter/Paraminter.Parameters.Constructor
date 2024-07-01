namespace Paraminter.Parameters;

using Microsoft.CodeAnalysis;

using System;

/// <summary>Handles <see cref="IGetMethodParameterBySymbolQuery"/>, and responds with <see cref="IMethodParameter"/>.</summary>
public sealed class GetMethodParameterBySymbolQueryHandler
    : IQueryHandler<IGetMethodParameterBySymbolQuery, IMethodParameter>
{
    /// <summary>Instantiates a <see cref="GetMethodParameterBySymbolQueryHandler"/>, handling <see cref="IGetMethodParameterBySymbolQuery"/>.</summary>
    public GetMethodParameterBySymbolQueryHandler() { }

    IMethodParameter IQueryHandler<IGetMethodParameterBySymbolQuery, IMethodParameter>.Handle(
        IGetMethodParameterBySymbolQuery query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        return new MethodParameter(query.Symbol);
    }

    private sealed class MethodParameter
        : IMethodParameter
    {
        private readonly IParameterSymbol Symbol;

        public MethodParameter(
            IParameterSymbol symbol)
        {
            Symbol = symbol;
        }

        IParameterSymbol IMethodParameter.Symbol => Symbol;
    }
}
