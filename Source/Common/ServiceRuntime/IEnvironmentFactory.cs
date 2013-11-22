namespace AzureMultiSite.ServiceRuntime
{
    public interface IEnvironmentFactory
    {
        IEnvironment CreateEnvironment();
    }
}