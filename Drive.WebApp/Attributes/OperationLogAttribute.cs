using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Drive.Model;


namespace Drive.WebApp.Attributes
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method,AllowMultiple=false)]
    public class OperationLogAttribute : ActionFilterAttribute
    {
        private Drive.IBLL.IOperLogService _bll = new Drive.BLL.OperLogService();
        private readonly string _content;
        public OperationLogAttribute(string content)
        {
            _content = content;
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (HttpContext.Current.Session["user_account"] == null) return;
            var user = HttpContext.Current.Session["user_account"] as T_Sys_User;

            T_Sys_Oper_Log operateLog = new T_Sys_Oper_Log
            {
                CreateTime = DateTime.Now, UserCode = user.UserCode, Content = _content
            };
            _bll.AddEntity(operateLog);
            base.OnActionExecuted(filterContext);
        }
    }
}