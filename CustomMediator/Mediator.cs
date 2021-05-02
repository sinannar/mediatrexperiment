using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public Task<TResponse> Send<TResponse>(IRequest<TResponse> request)
        {
            var handler = (IRequestHandler<IRequest<TResponse>, TResponse>)_serviceProvider.GetService(typeof(IRequestHandler<IRequest<TResponse>, TResponse>));
            return handler.Handle(request);
        }
    }
}
