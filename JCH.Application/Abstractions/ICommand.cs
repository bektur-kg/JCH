using MediatR;

namespace JCH.Application.Abstractions;

public interface ICommand<TResponse> : IRequest<TResponse>;