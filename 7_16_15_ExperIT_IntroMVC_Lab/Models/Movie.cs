using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _7_16_15_ExperIT_IntroMVC_Lab.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }


    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }


}