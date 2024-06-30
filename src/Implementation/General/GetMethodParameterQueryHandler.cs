namespace Paraminter.Parameters;

using Microsoft.CodeAnalysis;

using System;

/// <summary>Handles <see cref="IGetMethodParameterQuery"/>, and responds with <see cref="IMethodParameter"/>.</summary>
public sealed class GetMethodParameterQueryHandler
    : IQueryHandler<IGetMethodParameterQuery, IMethodParameter>
{
    /// <summary>Instantiates a <see cref="GetMethodParameterQueryHandler"/>, handling <see cref="IGetMethodParameterQuery"/>.</summary>
    public GetMethodParameterQueryHandler() { }

    IMethodParameter IQueryHandler<IGetMethodParameterQuery, IMethodParameter>.Handle(
        IGetMethodParameterQuery query)
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
