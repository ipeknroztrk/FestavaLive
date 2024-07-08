using AcunMedyaFestavaLive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Areas.Member.Controllers
{
    public class MemberLayoutController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView("~/Areas/Member/Views/MemberLayout/PartialHead.cshtml");
        }
        public PartialViewResult PartialSideBar()
        {
            return PartialView("~/Areas/Member/Views/MemberLayout/PartialSideBar.cshtml");
        }
        public PartialViewResult PartialScript()
        {
            return PartialView("~/Areas/Member/Views/MemberLayout/PartialScript.cshtml");
        }
        public PartialViewResult PartialLogoHeader()
        {
            return PartialView("~/Areas/Member/Views/MemberLayout/PartialLogoHeader.cshtml");
        }
        public PartialViewResult PartialNavbarHeader()
        {
            return PartialView("~/Areas/Member/Views/MemberLayout/PartialNavbarHeader.cshtml");
        }
    }
}