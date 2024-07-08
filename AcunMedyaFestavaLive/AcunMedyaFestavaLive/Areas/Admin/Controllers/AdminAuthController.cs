using AcunMedyaFestavaLive.Areas.Admin.Models;
using AcunMedyaFestavaLive.Entities;

using System.Linq;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Areas.Admin.Controllers
{
    public class AdminAuthController : Controller
    {
        private readonly Context context = new Context();

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(AdminLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var admin = context.admins.SingleOrDefault(a => a.Username == model.Username && a.Password == model.Password);

                if (admin != null)
                {
                    Session["AdminId"] = admin.AdminId;
                    Session["AdminUsername"] = admin.Username;

                    return RedirectToAction("CreateTicket", "AdminTicket");
                }

                ModelState.AddModelError("", "Geçersiz kullanıcı adı veya şifre.");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult SignOut()
        {
            Session.Clear();
            return RedirectToAction("SignIn");
        }
    }
}
