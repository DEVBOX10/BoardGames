using System;
using BoardGames.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Stl.Extensibility;

namespace BoardGames.HostServices
{
    [RegisterModule]
    public class HostServicesModule : AppModuleBase
    {
        public HostServicesModule(IServiceCollection services, IServiceProvider moduleBuilderServices)
            : base(services, moduleBuilderServices) { }
    }
}
