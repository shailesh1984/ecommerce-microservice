using MediatR;

namespace BuildingBlocks.CQRS;

/// <summary>
/// Abstraction of command operation
/// </summary>
public interface ICommand
    : ICommand<Unit>
{ }

public interface ICommand<out TResponse>
    : IRequest<TResponse>
{ }
