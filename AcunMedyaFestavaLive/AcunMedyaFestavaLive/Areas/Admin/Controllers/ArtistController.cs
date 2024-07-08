using AcunMedyaFestavaLive.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Areas.Admin.Controllers
{
    public class ArtistController : Controller
    {
        private Context context = new Context();

        public ActionResult List()
        {
            List<Artist> artists = context.artists.ToList();
            return View(artists);
        }

        [HttpGet]
        public ActionResult CreateArtist()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateArtist(Artist artist)
        {
            if (ModelState.IsValid)
            {
                context.artists.Add(artist);
                context.SaveChanges();
                return RedirectToAction("List");
            }
            return View(artist);
        }

        [HttpGet]
        public ActionResult UpdateArtist(int id)
        {
            Artist artist = context.artists.Find(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        [HttpPost]
        public ActionResult UpdateArtist(Artist artist)
        {
            if (ModelState.IsValid)
            {
                var existingArtist = context.artists.Find(artist.ArtistId);
                if (existingArtist != null)
                {
                    existingArtist.NameSurname = artist.NameSurname;
                    existingArtist.Date = artist.Date;
                    existingArtist.Description = artist.Description;
                    existingArtist.Description2 = artist.Description2;
                    existingArtist.ImageUrl = artist.ImageUrl;
                    context.SaveChanges();
                    return RedirectToAction("List");
                }
            }
            return View(artist);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteArtist(int id)
        {
            var artist = context.artists.Find(id);
            if (artist != null)
            {
                context.artists.Remove(artist);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
