using System.Linq;
using System.Web.Mvc;
using AcunMedyaFestavaLive.Entities;
using System.Web.Security;

namespace AcunMedyaFestavaLive.Areas.Member.Controllers
{
    public class UserController : Controller
    {
        private Context context = new Context();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var existingUser = context.users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);
            if (existingUser != null)
            {
                FormsAuthentication.SetAuthCookie(existingUser.Email, false);
                Session["UserId"] = existingUser.UserId;
                Session["UserName"] = existingUser.Name + " " + existingUser.Surname;
                Session["UserImage"] = existingUser.ImageUrl; 
                Session["Email"] = existingUser.Email;

                return RedirectToAction("BuyTicket", "MyTicket");
            }
            else
            {
                ViewBag.Message = "Geçersiz kullanıcı adı veya şifre.";
                return View();
            }
        }


        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Login", "User");
        }

    }
}
