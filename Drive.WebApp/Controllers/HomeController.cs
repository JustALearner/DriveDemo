using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Drive.Common;
using Drive.IBLL;
using Drive.WebApp.Models;
using PagedList;

namespace Drive.WebApp.Controllers
{
    public class HomeController : Controller
    {
//        Drive.IBLL.IUserInfoService _bll = new Drive.BLL.UserInfoService();

        public IUserInfoService Type { get; set; }
        //
        // GET: /Home/
        [HttpGet]
        //[AllowAnonymous]

        public ActionResult Index(int? page)
        {
            int pageNumber = page ?? 1;
            var ds = Drive.WebApp.Models.Resources.DriveSchools;
            IPagedList<DriveSchool> pagedList = ds.ToPagedList(pageNumber, 7);
            return View("IndexNew",pagedList);
        }
        public ActionResult IndexNew(int? page)
        {
            int pageNumber = page ?? 1;
            var ds = Drive.WebApp.Models.Resources.DriveSchools;
            IPagedList<DriveSchool> pagedList = ds.ToPagedList(pageNumber, 7);
            return View(pagedList);
        }

        public ActionResult queryOperLog()
        {
            return View();
        }

        /// <summary>
        /// 南湖驾校
        /// </summary>
        /// <returns></returns>
        public ActionResult nhjxView()
        {
            return View();
        }

        /// <summary>
        /// 瀚阳驾校
        /// </summary>
        /// <returns></returns>
        public ActionResult hyView()
        {
            return View();
        }


        /// <summary>
        /// 深港凯旋驾校
        /// </summary>
        /// <returns></returns>
        public ActionResult sghxView()
        {
            return View();
        }


        /// <summary>
        /// 申通驾校
        /// </summary>
        /// <returns></returns>
        public ActionResult stjxView()
        {
            return View();
        }


        /// <summary>
        /// 航邮驾校
        /// </summary>
        /// <returns></returns>
        public ActionResult hyjxView()
        {
            return View();
        }

        /// <summary>
        /// 赛达驾校
        /// </summary>
        /// <returns></returns>
        public ActionResult sdjxView()
        {
            return View();
        }
        /// <summary>
        /// 航邮驾校分校
        /// </summary>
        /// <returns></returns>
        public ActionResult hyjxfxView()
        {
            return View();
        }


        /// <summary>
        /// 报名咨询
        /// </summary>
        /// <returns></returns>
        public ActionResult zixun()
        {
            return View();
        }

    }
}
