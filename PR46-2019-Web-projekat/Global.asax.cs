using PR46_2019_Web_projekat.Models.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PR46_2019_Web_projekat
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_PostAuthorizeRequest()
        {
            System.Web.HttpContext.Current.SetSessionStateBehavior(System.Web.SessionState.SessionStateBehavior.Required);
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            UserManager listOfUsers = new UserManager("~/App_Data/Users.json");
            HttpContext.Current.Application["Users"] = listOfUsers as UserManager;

            CommentManager listOfComments = new CommentManager("~/App_Data/Comments.json");
            HttpContext.Current.Application["Comments"] = listOfComments as CommentManager;

            GroupTrainingManager listOfGroupTrainings = new GroupTrainingManager("~/App_Data/GroupTrainings.json");
            HttpContext.Current.Application["GroupTrainings"] = listOfGroupTrainings as GroupTrainingManager;

            FitnessCenterManager listOfFitnessCenters = new FitnessCenterManager("~/App_Data/FitnessCenters.json");
            HttpContext.Current.Application["FitnessCenters"] = listOfFitnessCenters as FitnessCenterManager;

            User user = new User();
            HttpContext.Current.Application["user"] = user as User;
        }
    }
}
