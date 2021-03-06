﻿using System.Web.Mvc;
using AzureMultiSite.ServiceRuntime;
using AzureMultiSite.Web.Public.Models;

namespace AzureMultiSite.Web.Public.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IEnvironment roleEnvironment)
        {
            _roleEnvironment = roleEnvironment;
        }

        public ActionResult Index()
        {
            return View(new HomeIndexViewModel
                            {
                                SettingValue = _roleEnvironment.GetSettingValue("name"),
                                LocalResourcePath = _roleEnvironment.GetLocalStoragePath("temp")
                            });
        }

        private readonly IEnvironment _roleEnvironment;
    }
}