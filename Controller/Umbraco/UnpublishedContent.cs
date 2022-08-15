using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Web.Common.Authorization;
using Umbraco.Cms.Web.Common.Filters;

namespace DemoUmbraco.Controller.Umbraco
{
    [Authorize(Policy = AuthorizationPolicies.BackOfficeAccess)]
    [DisableBrowserCache]
    // https://github.com/umbraco/Umbraco-CMS/blob/v9/contrib/src/Umbraco.Web.Common/Controllers/UmbracoAuthorizedController.cs
    public class AdminController : Microsoft.AspNetCore.Mvc.Controller
    {
        public AdminController(
            //ISearchService searchService
            )
        {
            //_searchService = searchService;
        }

        public IActionResult Index()
        {
            return View("UnpublishedContent");
        }
    }
}