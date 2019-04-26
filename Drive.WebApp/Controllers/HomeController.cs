using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Drive.Common;
using Drive.IBLL;
using Drive.Model;
using Drive.WebApp.Models;
using PagedList;

namespace Drive.WebApp.Controllers
{
    public class HomeController : Controller
    {
        //        Drive.IBLL.IUserInfoService _bll = new Drive.BLL.UserInfoService();
        public List<WordsViewModel> WordList { get; set; }

        public HomeController()
        {
            this.WordList = new List<WordsViewModel>
            {
                new WordsViewModel {Code = "001", Name = "fxx", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "002", Name = "sxx", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "003", Name = "xxx", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "004", Name = "qqq", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "005", Name = "呵呵", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "006", Name = "rXX", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "007", Name = "你妹", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "008", Name = "我次奥", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "009", Name = "牛B", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "010", Name = "我次奥r", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "011", Name = "国家级", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "012", Name = "世界级", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "013", Name = "最高级", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "014", Name = "最佳", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "015", Name = "最大", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "016", Name = "第一", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "017", Name = "唯一", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "018", Name = "首选", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "019", Name = "最好", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "020", Name = "最低", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "021", Name = "最便宜", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "022", Name = "最先进", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "023", Name = "最新技术", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "024", Name = "最科学", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "025", Name = "独家", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "026", Name = "绝对", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "027", Name = "独家", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "028", Name = "顶级", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "029", Name = "最新", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "030", Name = "金牌", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "031", Name = "名牌", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "031", Name = "优秀", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "032", Name = "绝对", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "033", Name = "领袖", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "034", Name = "王牌", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "035", Name = "对一无二", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "036", Name = "绝无仅有", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "037", Name = "史无前例", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "038", Name = "前无古人", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "039", Name = "万能", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "040", Name = "销量冠军", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "041", Name = "No.1", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "042", Name = "Top", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "043", Name = "极致", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "044", Name = "永久", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "045", Name = "顶尖", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "046", Name = "终极", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "047", Name = "最受欢迎", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "048", Name = "国家级产品", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "049", Name = "填补国内空白", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "050", Name = "第一品牌", CreateTime = DateTime.Now.AddDays(-1)},
                new WordsViewModel {Code = "051", Name = "顶级工艺", CreateTime = DateTime.Now.AddDays(-1)},
            };
        }
        public IUserInfoService Type { get; set; }
        //
        // GET: /Home/
        [HttpGet]
        //[AllowAnonymous]

//        public ActionResult Index(int? page)
//        {
//            int pageNumber = page ?? 1;
//            var ds = Drive.WebApp.Models.Resources.DriveSchools;
//            IPagedList<DriveSchool> pagedList = ds.ToPagedList(pageNumber, 7);
//            return View("IndexNew",pagedList);
//        }
        public ActionResult IndexNew(int? page, string type = "", string value = "")
        {
            int pageNumber = page ?? 1;
            if (value == "")
            {

                Resources res1 = new Resources();
                var ds = res1.DriveSchools();
                IPagedList<DriveSchool> pagedList = ds.ToPagedList(pageNumber, 7);
                ViewBag.DS = pagedList;
                ViewBag.type = "";
                ViewBag.value = "";
                return View();
            }
            else
            {
                Resources res = new Resources();
                var ds = res.DriveSchools();
                if (type == "license")
                {
                    if (value == "aa")
                    {
                        ds = ds.Where(t => t.License.ToLower().IndexOf("a1", StringComparison.OrdinalIgnoreCase) > -1 || t.License.ToLower().IndexOf("a2", StringComparison.OrdinalIgnoreCase) > -1).ToList();
                    }
                    else if (value == "bb")
                    {
                        ds = ds.Where(t => t.License.ToLower().IndexOf("b1", StringComparison.OrdinalIgnoreCase) > -1 || t.License.ToLower().IndexOf("b2", StringComparison.OrdinalIgnoreCase) > -1).ToList();
                    }
                    else
                    {
                        ds = ds.Where(t => t.License.ToLower().IndexOf(value, StringComparison.OrdinalIgnoreCase) > -1).ToList();
                    }


                    IPagedList<DriveSchool> pagedList = ds.ToPagedList(pageNumber, 7);
                    ViewBag.DS = pagedList;
                    ViewBag.type = type;
                    ViewBag.value = value;
                    return View();
                }
                else if (type == "price")
                {
                    switch (value)
                    {
                        case "1":
                            ds = ds.Where(t => int.Parse(t.Money) <= 3000).ToList();
                            break;
                        case "2":
                            ds = ds.Where(t => int.Parse(t.Money) > 3000 && int.Parse(t.Money) <= 4000).ToList();
                            break;
                        case "3":
                            ds = ds.Where(t => int.Parse(t.Money) > 4000 && int.Parse(t.Money) <= 5000).ToList();
                            break;
                        case "4":
                            ds = ds.Where(t => int.Parse(t.Money) > 5000).ToList();
                            break;
                    }

                    IPagedList<DriveSchool> pagedList = ds.ToPagedList(pageNumber, 7);
                    ViewBag.DS = pagedList;
                    ViewBag.type = type;
                    ViewBag.value = value;
                    return View();

                }
            }

            return View();
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
        public JsonResult Words()
        {

            //         return Json(new {total=this.WordList.Count(),rows=this.WordList}, JsonRequestBehavior.AllowGet);
            return Json(this.WordList);
        }


        public ActionResult SensitiveWord()
        {
            return View();
        }

        public ActionResult Manage()
        {
            return View();
        }
    }
}
