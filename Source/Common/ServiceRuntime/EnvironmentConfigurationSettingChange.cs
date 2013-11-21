namespace AzureMultiSite.ServiceRuntime
{
    public sealed class EnvironmentConfigurationSettingChange
    {
        public EnvironmentConfigurationSettingChange(string settingName)
        {
            SettingName = settingName;
        }

        public string SettingName { get; private set; }
    }
}