using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.Mvc;
using Kurs2._0.Models;

namespace Kurs2._0.Controllers
{
    public class MusiciansController : Controller
    {
        //
        // GET: /Musicians/

        
        MusicContext db = new MusicContext();

        public ActionResult Index()
        {
            IEnumerable<Musician> mus = db.Musicians;
            ViewBag.Musicians = mus;
            return View();
        }

        [HttpGet]
        public ActionResult Musician(int id)
        {
            ViewBag.Mus = db.Musicians.Find(id);
            var a = db.Musicians.Find(id).Albums;
            //db.AlbumM2MMusicians.Add(new AlbumM2MMusician { Album = db.Albums.Find(0), Desription = "", Musician = db.Musicians.Find(0), Role = "" });
            //var b  = db.AlbumM2MMusicians.Where(m=>m.Musician == db.Musicians.Find(id));
            //ViewBag.Alb = db.Albums.Where(m => Equals(m,b));
            return View();
        }

        [HttpGet]
        public ActionResult AddPage()
        {
            return View();
        }

        [HttpPost]
        public string Add(Musician m)
        {
            db.Musicians.Add(m);
            db.SaveChanges();
            return "OK";
        }
    }
}
