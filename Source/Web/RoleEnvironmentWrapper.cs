using Microsoft.WindowsAzure.ServiceRuntime;

namespace Web
{
	public static class RoleEnvironmentWrapper
	{
		public static string GetSettingValue(string name)
		{
			return RoleEnvironment.IsAvailable ?
				RoleEnvironment.GetConfigurationSettingValue(name) :
				"nan";
		}

		public static string GetLocalStoragePath(string name)
		{
			return RoleEnvironment.IsAvailable
					   ? RoleEnvironment.GetLocalResource(name).RootPath :
					   "nan";
		}
	}
}