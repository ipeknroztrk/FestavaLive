using AcunMedyaFestavaLive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
           
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }
        public PartialViewResult PartialMeetArtist()
        {
            var values = context.artists.OrderBy(x => x.ArtistId).Take(6).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialEventSchedule()
        {
            return PartialView();
        }
        public PartialViewResult PartialTicket()
        {
            var values = context.tickets.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialContact()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
    }
}