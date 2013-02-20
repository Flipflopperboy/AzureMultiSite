using Web.Models;

namespace Web.ModelBuilders
{
	public sealed class HomeIndexViewModelBuilder
	{
		public HomeIndexViewModel Build()
		{
			return new HomeIndexViewModel()
					   {
						   SettingValue = RoleEnvironmentWrapper.GetSettingValue("name"),
						   LocalResourcePath = RoleEnvironmentWrapper.GetLocalStoragePath("temp")
					   };
		}
	}
}