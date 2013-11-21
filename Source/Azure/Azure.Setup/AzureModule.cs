using Autofac;
using AzureMultiSite.Azure.ServiceRuntime;
using AzureMultiSite.ServiceRuntime;

namespace AzureMultiSite.Azure.Setup
{
    public sealed class AzureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<AzureRoleEnvironment>()
                .As<IEnvironment>()
                .SingleInstance();
        }
    }
}