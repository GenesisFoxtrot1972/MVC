using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Web;

namespace Kurs2._0.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverPath { get; set; }
        public string Text { get; set; }
        public virtual ICollection<Musician> Musicians { get; set; }
    }
}