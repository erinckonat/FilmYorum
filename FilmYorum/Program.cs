using FilmYorum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    private static void Main(string[] args)
    {
        FilmSinifiEkle();
        FilmEkle();
        FilmleriListele();
        FilmleriSil();
    }


    public static void FilmSinifiEkle()
    {
        var context = new FilmContext();
        Console.Write("Filmin Türü Nedir:");
        var girilen = Console.ReadLine();

        var turAd = girilen;
        var sinif = context.FilmSinifs.FirstOrDefault(fs => fs.TurAd == turAd);
        if (sinif == null)
        {
            var yeniFilmSinif = new FilmSinifi();
            yeniFilmSinif.TurAd = turAd;
            context.FilmSinifs.Add(yeniFilmSinif);
            context.SaveChanges();

        }
        else
        {
            sinif.TurAd = turAd;
            context.SaveChanges();
           
        }

    }
    public static void FilmEkle()
    {
        var context = new FilmContext();
        foreach (var filmSinif in context.FilmSinifs)
        {
            Console.WriteLine($"Id:{filmSinif.Id} Filmin Türü: {filmSinif.TurAd}");
        }

        Console.Write("Film bilgilerini giriniz(Film Adı-Imbd Puanı-Film Yılı-Tür Id)");


        var filmGirilen = Console.ReadLine();
        var parcalar = filmGirilen.Split('-');
        var FilmAdi = parcalar[0];

      var FilmPuani = double.Parse(parcalar[1]);
        var FilmYili = int.Parse(parcalar[2]);
        var TurId = Convert.ToInt32((parcalar[3]));
        var yeniFilm = new Film();
        
        yeniFilm.FilmAdi = FilmAdi;
        yeniFilm.FilmPuani = FilmPuani;
        yeniFilm.FilmYili = FilmYili;
        yeniFilm.TurId = TurId;

        context.Films.Add(yeniFilm);
        context.SaveChanges();





       



    }
    public static void FilmleriListele()

    {
        Console.WriteLine("*********************************");
        var context = new FilmContext();
        var list = context.Films.ToList();
        foreach (var film in list)
        {
            Console.WriteLine(film);
        }
        Console.ReadLine();



    }
    public static void FilmleriSil()
    {
        var context = new FilmContext();
        Console.WriteLine("Silmek istediğiniz filmin Id:");
        var silinecekFilmId=Convert.ToInt32(Console.ReadLine());

        var film = context.Films.FirstOrDefault(f => f.Id == silinecekFilmId);

             context.Remove(film);   
            context.SaveChanges() ;
            FilmleriListele();  
        if(film == null)

        {

         Console.WriteLine("Böyle bir öğrenci bulunamadı");
        
        
        
         
        }

        
        
           
            
    }
}








