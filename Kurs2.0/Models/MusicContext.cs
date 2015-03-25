using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
  

namespace Kurs2._0.Models
{
    public class MusicContext : DbContext
    {
        public virtual DbSet<Musician> Musicians { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        //public DbSet<AlbumM2MMusician> AlbumM2MMusicians { get; set; }

        
        /**public MusicContext() : base("DefaultConnection")
        {
        }**/



        /**protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasMany<Musician>(a => a.Musicians)
                .WithMany(m => m.Albums)
                .Map(t => t.MapLeftKey("AlbumId")
                    .MapRightKey("MusicianId")
                    .ToTable("AlbumM2MMusician"));
        }**/


    }
}
