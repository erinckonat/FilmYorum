using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYorum
{
    public class Film
    {
        
         public override string ToString()
        {
            return $"Id:{this.Id} Ad:{this.FilmAdi} ImdbPuan:{this.FilmPuani}Film Yılı:{this.FilmYili}TurId:{this.TurId}";
        }
        public int Id { get; set; }
        [StringLength(200)]
        public string FilmAdi { get; set; }
        [StringLength(200)]

        public double FilmPuani { get; set; }
       
        public int FilmYili { get; set;}

        public int TurId { get; set; }

       
    }
}
