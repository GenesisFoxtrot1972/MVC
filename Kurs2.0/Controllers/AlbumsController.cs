using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kurs2._0.Models;

namespace Kurs2._0.Controllers
{
    public class AlbumsController : Controller
    {
        //
        // GET: /Albums/

        MusicContext db = new MusicContext();

        public ActionResult Index()
        {
            DbSet mus = db.Albums;

            ViewBag.Albums = mus;
            foreach (Album v in db.Albums)
            {
                //v.Musicians = new List<Musician>();
                //v.Musicians.Add(db.Musicians.First()); 
            }
            db.Albums.Find(1).Musicians = new List<Musician>();
            db.Albums.Find(1).Musicians.Add(db.Musicians.Find(1));
            var f = db.Albums.Find(1);
            //db.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Album(int id)
        {
            ViewBag.Mus = db.Albums.Find(id);
            var f = db.Albums.Find(id).Musicians;
            ViewBag.M = db.Albums.Find(id).Musicians;
            var a = db.Albums.Find(id).Musicians;
            return View();
        }

        [HttpGet]
        public ActionResult AddPage()
        {
            return View();
        }

        [HttpPost]
        public string Add(Album m)
        {
            db.Albums.Add(m);
            db.SaveChanges();
            return "OK";
        }

    }
}
