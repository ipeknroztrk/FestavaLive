using System.Linq;
using System.Web.Mvc;
using AcunMedyaFestavaLive.Entities;
using System.Web.Security;

namespace AcunMedyaFestavaLive.Areas.Member.Controllers
{
    public class MyTicketController : Controller
    {
        private Context context = new Context();

        [HttpGet]
        public ActionResult BuyTicket()
        {
            var tickets = context.tickets.ToList();
            return View(tickets);
        }

        [HttpPost]
        public ActionResult BuyTicket(int ticketId, int quantity)
        {
            var selectedTicket = context.tickets.FirstOrDefault(t => t.TicketId == ticketId);
            if (selectedTicket != null)
            {
                var userId = (int)Session["UserId"];
                var user = context.users.FirstOrDefault(u => u.UserId == userId);
                var userBuy = new UserBuy
                {
                    NameSurname = user.Name + " " + user.Surname,
                    Email = user.Email,
                   
                    TicketId = selectedTicket.TicketId,
                    Number = quantity
                };

                context.userBuys.Add(userBuy);
                context.SaveChanges();

                ViewBag.Message = "Bilet satın alma işlemi başarılı.";
                return RedirectToAction("MyTicketList", "MyTicket");
            }
            else
            {
                ViewBag.Message = "Bilet bulunamadı.";
                return View();
            }
        }
        public ActionResult MyTicketList()
        {
          
            if (Session["Email"] == null)
            {
                return RedirectToAction("Login", "User");
            }

            string userEmail = Session["Email"] as string;

           
            var userTickets = context.userBuys
                                     .Where(ub => ub.Email == userEmail)
                                     .Select(ub => ub.Ticket)
                                     .ToList();

           
            return View(userTickets);
        }
        public ActionResult ActiveTicket(Ticket ticket)
        {
            var activeTickets = context.tickets
                                      .Where(t => t.Status == true)
                                      .ToList();

            return View(activeTickets);
        }
        

        }







    }

