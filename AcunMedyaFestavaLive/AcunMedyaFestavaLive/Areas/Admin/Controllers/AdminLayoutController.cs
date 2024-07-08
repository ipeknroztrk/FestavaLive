using AcunMedyaFestavaLive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView("~/Areas/Admin/Views/AdminLayout/PartialHead.cshtml");
        }
        public PartialViewResult PartialSideBar()
        {
            return PartialView("~/Areas/Admin/Views/AdminLayout/PartialSideBar.cshtml");
        }
        public PartialViewResult PartialScript()
        {
            return PartialView("~/Areas/Admin/Views/AdminLayout/PartialScript.cshtml");
        }
        public PartialViewResult PartialLogoHeader()
        {
            return PartialView("~/Areas/Admin/Views/AdminLayout/PartialLogoHeader.cshtml");
        }
        public PartialViewResult PartialNavbarHeader()
        {
            return PartialView("~/Areas/Admin/Views/AdminLayout/PartialNavbarHeader.cshtml");
        }
    }
}