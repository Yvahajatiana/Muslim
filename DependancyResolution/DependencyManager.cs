using Microsoft.Extensions.DependencyInjection;
using Muslim.DependencyResolution.Registries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Muslim.DependencyResolution
{
    public sealed class DependencyManager
    {
        private static readonly Lazy<DependencyManager> instance =
            new Lazy<DependencyManager>(() => new DependencyManager(), LazyThreadSafetyMode.ExecutionAndPublication);

        private DependencyManager()
        {

        }

        public static DependencyManager Instance
        {
            get
            {
                return instance.Value;
            }
        }

        public void BluidDependencies(IServiceCollection services)
        {
            var type = typeof(IDependency);

            var typeInfo = type.GetTypeInfo();

            var instances = typeInfo
                .Assembly
                .GetExportedTypes()
                .Where(t => type.IsAssignableFrom(t) && t.GetTypeInfo().IsClass)
                .Select(t => Activator.CreateInstance(t) as IDependency)
                .ToList();

            instances.ForEach(instance => instance.Register(services));   
        }
    }
}
