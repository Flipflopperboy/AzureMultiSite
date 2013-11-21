using System;

namespace AzureMultiSite.ServiceRuntime
{
    public interface IEnvironment
    {
        string GetSettingValue(string name);
        string GetLocalStoragePath(string name);
        event EventHandler<EnvironmentConfigurationSettingChangeArgs> SettingsChanged;
    }
}