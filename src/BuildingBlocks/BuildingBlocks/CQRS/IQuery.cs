using MediatR;

namespace BuildingBlocks.CQRS;

/// <summary>
/// Abstraction of query operation
/// </summary>
public interface IQuery<out TResponse>
    : IRequest<TResponse>
    where TResponse : notnull
{ }
