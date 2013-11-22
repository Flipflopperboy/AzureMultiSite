using AzureMultiSite.ServiceRuntime;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace AzureMultiSite.Azure.ServiceRuntime
{
    public sealed class AzureRoleEnvironmentFactory : IEnvironmentFactory
    {
        public IEnvironment CreateEnvironment()
        {
            if (RoleEnvironment.IsAvailable)
            {
                return new AzureRoleEnvironment();
            }
            else
            {
                return new AzureLocalEnvironment();
            }
        }
    }
}