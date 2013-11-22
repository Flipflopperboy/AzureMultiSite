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
                .RegisterType<AzureRoleEnvironmentFactory>()
                .As<IEnvironmentFactory>()
                .SingleInstance();

            builder
                .Register(context =>
                              {
                                  var factory = context.Resolve<IEnvironmentFactory>();
                                  return factory.CreateEnvironment();
                              })
                .As<IEnvironment>()
                .SingleInstance();
        }
    }
}