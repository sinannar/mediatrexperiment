using System;
using System.Threading.Tasks;

namespace CustomMediator
{
    public class Mediator : IMediator
    {
        IServiceProvider _serviceProvider;

        public Mediator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task<TResponse> Send<TRequest, TResponse>(TRequest request) where TRequest : IRequest<TResponse>
        {
            var handler = (IRequestHandler<TRequest, TResponse>)_serviceProvider.GetService(typeof(IRequestHandler<TRequest, TResponse>));
            return handler.Handle(request);
        }
    }
}
