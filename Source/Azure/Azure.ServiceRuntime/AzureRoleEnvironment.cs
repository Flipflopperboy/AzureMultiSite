using System;
using System.Collections.Generic;
using System.Linq;
using AzureMultiSite.ServiceRuntime;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace AzureMultiSite.Azure.ServiceRuntime
{
    public sealed class AzureRoleEnvironment : IEnvironment
    {
        public AzureRoleEnvironment()
        {
            if (RoleEnvironment.IsAvailable)
            {
                RoleEnvironment.Changed += RoleEnvironmentOnChanged;
            }
        }

        public string GetSettingValue(string name)
        {
            return RoleEnvironment.IsAvailable
                       ? RoleEnvironment.GetConfigurationSettingValue(name)
                       : "tbd";
        }

        public string GetLocalStoragePath(string name)
        {
            return RoleEnvironment.IsAvailable
                       ? RoleEnvironment.GetLocalResource(name).RootPath
                       : "tbd";
        }

        public event EventHandler<EnvironmentConfigurationSettingChangeArgs> SettingsChanged;

        private void RoleEnvironmentOnChanged(object sender, RoleEnvironmentChangedEventArgs args)
        {
            List<EnvironmentConfigurationSettingChange> changedSettings =
                args.Changes
                    .OfType<RoleEnvironmentConfigurationSettingChange>()
                    .Select(s => new EnvironmentConfigurationSettingChange(s.ConfigurationSettingName))
                    .ToList();

            if (changedSettings.Count > 0)
            {
                RaiseChanged(changedSettings);
            }
        }

        private void RaiseChanged(IEnumerable<EnvironmentConfigurationSettingChange> changes)
        {
            if (SettingsChanged == null)
            {
                SettingsChanged(this, new EnvironmentConfigurationSettingChangeArgs(changes));
            }
        }
    }
}