﻿namespace JCH.Application.Abstractions;

/// <summary>
/// Represents a handler for a command that returns a response.
/// </summary>
/// <typeparam name="TCommand">The type of the command being handled.</typeparam>
/// <typeparam name="TResponse">The type of the response returned by the command.</typeparam>
public interface ICommandHandler<TCommand, TResponse>
    : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>;