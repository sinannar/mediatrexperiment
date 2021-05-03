using System.Threading.Tasks;

namespace CustomMediator
{
    public interface IMediator
    {
        public Task<TResponse> Send<TRequest, TResponse>(TRequest request) where TRequest : IRequest<TResponse>;
    }
}
