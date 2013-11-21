using System.Collections.Generic;

namespace AzureMultiSite.ServiceRuntime
{
    public sealed class EnvironmentConfigurationSettingChangeArgs
    {
        public EnvironmentConfigurationSettingChangeArgs(
            IEnumerable<EnvironmentConfigurationSettingChange> changes)
        {
            Changes = changes;
        }

        public IEnumerable<EnvironmentConfigurationSettingChange> Changes { get; private set; }
    }
}