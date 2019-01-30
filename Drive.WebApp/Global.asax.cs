using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using Drive.Model;
using Drive.WebApp.Attributes;
using Newtonsoft.Json;
using Spring.Web.Mvc;

namespace Drive.WebApp
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801
//修改
    public class MvcApplication : SpringMvcApplication  //System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            if (authCookie == null || string.IsNullOrEmpty(authCookie.Value))
            {
                return;
            }

            FormsAuthenticationTicket authticket;
            try
            {
                authticket = FormsAuthentication.Decrypt(authCookie.Value);
            }
            catch (Exception exception)
            {
                return;
            }

            var userdata = authticket.UserData;
            if (Context.User != null)
                //把权限赋值给当前用户
            {
                Context.User = new MyFormsPrincipal<T_Sys_Role>(authticket,
                    JsonConvert.DeserializeObject<T_Sys_Role>(userdata));
            }
        }


    }
}