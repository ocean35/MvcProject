using FluentValidation.Mvc;
using MvcProject.BusinessLayer.ValidationRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcProject
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ValidatorConfiguration();
        }

        private void ValidatorConfiguration()
        {
            FluentValidationModelValidatorProvider.Configure(provider =>
            {
                provider.ValidatorFactory = new ValidatorFactoryAbout();
                provider.ValidatorFactory = new ValidatorFactoryCategory();
            });
        }
    }
}
