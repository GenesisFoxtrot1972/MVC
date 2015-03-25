using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kurs2._0.Models;

namespace Kurs2._0.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        MusicContext db = new MusicContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Musician> mus = db.Musicians;
            // передаем все полученный объекты в динамическое свойство Books в ViewBag
            ViewBag.Musicians = mus;
            // возвращаем представление
            return View();
        }

        [HttpGet]
        public ActionResult Buy()
        {
            //ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Musician m)
        {
            //purchase.Date = DateTime.Now;
            // добавляем информацию о покупке в базу данных
            db.Musicians.Add(m);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо," + m.Name + ", за покупку!";
        }
       

    }
}
