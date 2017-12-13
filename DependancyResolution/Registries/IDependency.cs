using Microsoft.Extensions.DependencyInjection;

namespace Muslim.DependencyResolution.Registries
{
    public interface IDependency
    {
        void Register(IServiceCollection services);
    }
}