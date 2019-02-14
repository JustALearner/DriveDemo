using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using Drive.Common;
using Drive.IBLL;
using Drive.Model;
using Drive.Model.VM;
using Drive.WebApp.Attributes;
using Newtonsoft.Json;

namespace Drive.WebApp.Controllers
{
    public class AccountController : Controller
    {
//        readonly IBLL.IUserInfoService _userBll = new BLL.UserInfoService();
//
//        readonly IBLL.IOperLogService _logBll = new BLL.OperLogService();
        public IUserInfoService UserBll { get; set; }
        public IOperLogService LogBll { get; set; }
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [OperationLog("用户登录")]
        //  [ValidateAntiForgeryToken]
        public JsonResult Login(LoginViewModel model)
        {

            if (!ModelState.IsValid)
            {
                //  return View(model);
                return Json(new { code = -1, url = "", msg = "数据不合法" });
            }
            if (model.UserCode.Trim() == "admin" && model.Password.Trim() == "pass")
            {
                var authTicket = new FormsAuthenticationTicket(1, model.UserCode, DateTime.Now,
                    DateTime.Now.AddMinutes(20), false, JsonConvert.SerializeObject(new T_Sys_Role { usercode = "admin", role = "123" }));

                string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket)
                {
                    HttpOnly = true,
                    Secure = FormsAuthentication.RequireSSL,
                    Domain = FormsAuthentication.CookieDomain,
                    Path = FormsAuthentication.FormsCookiePath,
                    Expires = DateTime.Now.AddMinutes(20)
                };
                //客户端脚本不能访问
                //是否仅用https传递cookie
                //与cookie关联的域
                //cookie关联的虚拟路径
                HttpContext context =System.Web.HttpContext.Current;
                if (context == null)
                    throw new InvalidOperationException();

                // 5. 写登录Cookie
                context.Response.Cookies.Remove(authCookie.Name);
                context.Response.Cookies.Add(authCookie);
                Response.Cookies.Add(authCookie);
                 //HttpContext.User = new MyFormsPrincipal<T_Sys_User>(authTicket, new T_Sys_User() { UserCode = model.UserCode });
                //FormsAuthentication.SetAuthCookie(model.UserCode, true);

                //                if (Url.IsLocalUrl(returnUrl))
                //                {
                //                    return Redirect(returnUrl);
                //                }

                //  return RedirectToAction("Index", new RouteValueDictionary(new { controller = "Home", action = "Index" }));
                System.Web.HttpContext.Current.Session["user_account"] = new T_Sys_User { UserCode="admin"};
                return Json(new { code = 0, url = "/Home/IndexNew", msg = "" });
              
            }
            else
            {
                var pwd = Encryptor.Md5Hash(model.Password);
                //根据用户登录名查询指定用户实体
                var user = UserBll.LoadEntities(t => t.UserCode == model.UserCode && t.Password == pwd).FirstOrDefault();

                //如果用户不存在，则携带错误消息并返回登录页面
                if (user == null)
                {
                    //ModelState.AddModelError("error_message", "用户不存在");
                    //return View(model);
                    return Json(new { code = "-1", url = "", msg = "用户不存在" });
                }

                //如果密码不匹配，则携带错误消息并返回登录页面
                if (user.Password != Encryptor.Md5Hash(model.Password.Trim()))
                {
                    //                    ModelState.AddModelError("error_message", "密码错误,请重新登录");
                    //                    return View(model);
                    return Json(new { code = "-2", url = "", msg = "密码错误,请重新登录" });
                }
                FormsAuthentication.SetAuthCookie(user.UserCode, true);
                //将用户实体保存到Session中
                System.Web.HttpContext.Current.Session["user_account"] = user;
                return Json(new { code = 0, url = "/Home/IndexNew", msg = "" });

            }

            // return View();
            //return Json(new { code = "-3", url = "", msg = "请检查录入的数据" });
        }
        [Authorize]
        [OperationLog("登出")]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();//通过Forms验证来删除Cookie
            return RedirectToAction("Index", "Home");
        }


        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {          
                return Json(new { code = -1, url = "", msg = "数据不合法" });
            }

            //根据用户登录名查询指定用户实体
            var user = UserBll.LoadEntities(t => t.UserCode == model.UserCode).FirstOrDefault();

            //如果用户不存在，则携带错误消息并返回登录页面
            if (user != null)
            {
                return Json(new { code = "-2", url = "", msg = "用户名已存在" });
            }
          

           var ret=  UserBll.AddEntity(new T_Sys_User()
                {Password = Encryptor.Md5Hash(model.Password), UserCode = model.UserCode});
           
            return Json(new { code = "0", url = "/Account/Login", msg = "注册成功,请登录" });
        }

        [HttpPost]
        public ActionResult queryLog(string userCode,string content)
        {
            System.Linq.Expressions.Expression<Func<T_Sys_Oper_Log, bool>> whereLambda = t => t.Id > 0;
            if (!string.IsNullOrEmpty(userCode)) {
                whereLambda = t => t.UserCode == userCode  && t.Content.Contains(content);
            }
            //根据用户登录名查询指定用户实体
            var data = LogBll.LoadEntities(whereLambda);
            List<Dictionary<string, string>> rs = new List<Dictionary<string, string>>();
            int i = 1;
            foreach (var d in data) {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic["IndexCode"] = i+"";
                dic["UserCode"] = d.UserCode;
                dic["UserName"] = d.UserName;
                dic["LogType"] = d.LogType;
                DateTime date = d.CreateTime.Value;
                dic["CreateTime"] = date.ToString("yyyy-MM-dd HH:mm:ss");
                dic["Content"] = d.Content;
                rs.Add(dic);
                i++;
            }

            var s = Json(new { Data = rs });
            return s;
        }
    }
}
