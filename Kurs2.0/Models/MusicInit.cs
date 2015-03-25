using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kurs2._0.Models
{
    public class MusicInit : DropCreateDatabaseAlways<MusicContext>
    {

        protected override void Seed(MusicContext db)
        {
            Musician m1 = new Musician() { Name = "Jim", Surname = "Page", Secondname = "", Albums = new List<Album>() };
            db.Musicians.Add(m1);
            Musician m2 = new Musician() { Name = "Jim", Surname = "Hendrix", Secondname = "", Albums = new List<Album>() };
            db.Musicians.Add(m2);
            db.Albums.Add(new Album { Title = "LZ I", Text = "Page", CoverPath = @"D:\Media\Files\Picture\Обои\Постеры\1.png", Musicians = new List<Musician>() { m1, m2 } });
            db.Albums.Add(new Album { Title = "LZ II", Text = "Page", CoverPath = "", Musicians = new List<Musician>(){m1, m2}});

          
            base.Seed(db);
        }

    }
}