using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public abstract class App<T> : Worker
    {
        protected readonly T _svc;


        public App()
        {
            _svc = _serviceProvider.GetRequiredService<T>();
        }
    }
}
