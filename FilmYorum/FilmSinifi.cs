using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYorum
{
    public class FilmSinifi
    {
        [Key]
        public  int Id { get; set; }
        public string TurAd { get; set; }
        //public FilmSinifi filmSinifi { get; set; }


    }   
}
