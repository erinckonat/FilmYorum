using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYorum
{
    public class FilmContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            

            optionsBuilder.UseSqlServer("Server=LENOVOTP\\SQLEXPRESSS;Database=Film;User Id =sa;Password=e22792279;Trust Server Certificate=true");
            base.OnConfiguring(optionsBuilder);
        }
         
        public virtual DbSet<FilmSinifi>FilmSinifs{ get; set; }
        public virtual DbSet<Film> Films { get; set; }

    }
}
