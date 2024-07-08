using AcunMedyaFestavaLive.Entities;
using System.Linq;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Areas.Member.Controllers
{
    public class TicketController : Controller
    {
        private readonly Context _context;

        public TicketController()
        {
            _context = new Context();
        }

        // GET: Member/Ticket/BuyTicket
        public ActionResult BuyTicket()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BuyTicket(UserBuy userBuy)
        {
            if (ModelState.IsValid)
            {
                // Örneğin, UserBuy nesnesini kaydetme işlemi
                _context.userBuys.Add(userBuy); // "UserBuys" tablosuna ekleyin
                _context.SaveChanges();

                // Başarılı kayıt sonrası yönlendirme veya mesaj gösterme
                return RedirectToAction("MyTicketList", "MyTicket", new { area = "Member" });
            }

            return View(userBuy); // ModelState geçerli değilse aynı sayfada formu yeniden gösterin
        }

        // Kullanıcının biletlerini listeleyecek action
        public ActionResult TicketList()
        {

            return View();
        }
    }
}
