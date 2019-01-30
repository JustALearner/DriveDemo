using System.Web.Mvc;

namespace Drive.WebApp.Controllers
{
    public class UserInfoController : Controller
    {
        //
        // GET: /UserInfo/
        Drive.IBLL.IUserInfoService bll = new Drive.BLL.UserInfoService();
        public ActionResult Index()
        {
            ViewData.Model = bll.LoadEntities(c=>true);
            return View();
        }

    }
}
