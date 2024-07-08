using AcunMedyaFestavaLive.Entities;
using System.Linq;
using System.Web.Mvc;


namespace AcunMedyaFestavaLive.Areas.Admin.Controllers
    {
        public class AdminTicketController : Controller
        {
            Context context = new Context();

            public ActionResult TicketList()
            {
                var values = context.tickets.ToList();
                return View(values);
            }

            [HttpGet]
            public ActionResult CreateTicket()
            {
                return View();
            }

            [HttpPost]
            public ActionResult CreateTicket(Ticket ticket)
            {
                context.tickets.Add(ticket);
                context.SaveChanges();
                return RedirectToAction("TicketList");
            }

            public ActionResult DeleteTicket(int id)
            {
                var values = context.tickets.Find(id);
                context.tickets.Remove(values);
                context.SaveChanges();
                return RedirectToAction("TicketList");
            }

            [HttpGet]
            public ActionResult UpdateTicket(int id)
            {
                var value = context.tickets.Find(id);
                if (value == null)
                {
                    return HttpNotFound();
                }
                return View(value);
            }

        [HttpPost]
        public ActionResult UpdateTicket(int id, Ticket ticket)
        {
            var value = context.tickets.Find(id);
            if (value != null)
            {
                value.TicketProperty1 = ticket.TicketProperty1;
                value.TicketProperty2 = ticket.TicketProperty2;
                value.TicketProperty3 = ticket.TicketProperty3;
                value.TicketProperty4 = ticket.TicketProperty4;
                value.TicketProperty5 = ticket.TicketProperty5;
                value.TicketProperty6 = ticket.TicketProperty6;
                value.Price = ticket.Price;
                value.Description = ticket.Description;
                value.Title = ticket.Title;
                context.SaveChanges();
            }
            return RedirectToAction("TicketList");
        }


        public ActionResult TicketDetails(int id)
            {
                var value = context.tickets.Find(id);
                if (value == null)
                {
                    return HttpNotFound();
                }
                return View(value);
            }
        public ActionResult ActivateTicket(int id)
        {
            var ticket = context.tickets.Find(id);
            if (ticket != null)
            {
                ticket.Status = true; // Aktif yapma
                context.SaveChanges();
            }
            return RedirectToAction("TicketList");
        }

        public ActionResult DeactivateTicket(int id)
        {
            var ticket = context.tickets.Find(id);
            if (ticket != null)
            {
                ticket.Status = false; // Pasif yapma
                context.SaveChanges();
            }
            return RedirectToAction("TicketList");
        }

        public ActionResult ActiveTickets()
        {
            var values = context.tickets.Where(t => t.Status).ToList();
            return View(values);
        }
    }


    }