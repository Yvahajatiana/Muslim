using Microsoft.Extensions.DependencyInjection;
using Muslim.Core.Domain;
using Muslim.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Muslim.DependencyResolution.Registries
{
    public sealed class InfrastructureDependencyRegistry : IDependency
    {
        public void Register(IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
