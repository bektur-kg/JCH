namespace JCH.Application.Abstractions;

/// <summary>
/// Represents a command with a response type.
/// </summary>
/// <typeparam name="TResponse">The type of the response that the command returns.</typeparam>
public interface ICommand<TResponse> : IRequest<TResponse>;