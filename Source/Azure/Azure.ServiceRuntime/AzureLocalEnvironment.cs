using System;
using System.Collections.Generic;
using AzureMultiSite.ServiceRuntime;

namespace AzureMultiSite.Azure.ServiceRuntime
{
    public sealed class AzureLocalEnvironment : IEnvironment
    {
        public string GetSettingValue(string name)
        {
            return "tbd";
        }

        public string GetLocalStoragePath(string name)
        {
            return "tbd";
        }

        public event EventHandler<EnvironmentConfigurationSettingChangeArgs> SettingsChanged;

        private void RaiseChanged(IEnumerable<EnvironmentConfigurationSettingChange> changes)
        {
            if (SettingsChanged == null)
            {
                SettingsChanged(this, new EnvironmentConfigurationSettingChangeArgs(changes));
            }
        }
    }
}