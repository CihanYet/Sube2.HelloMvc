using Microsoft.AspNetCore.Mvc;
using Sube2.HelloMvc.Models;

namespace Sube2.HelloMvc.Controllers
{
    public class OgrenciController : Controller
    {
        public ViewResult Index()//Action
        {
            return View();
        }

        public string OgrenciDetay(int id)
        {
            Ogrenci ogr = null;
            if (id == 1)
            {
                ogr = new Ogrenci();
                ogr.Ad = "Ali";
                ogr.Soyad = "Veli";
                ogr.Numara = 123;
            }
            else if (id == 2)
            {
                ogr = new Ogrenci { Ad = "Ahmet", Soyad = "Mehmet", Numara = 456 };
            }
            return ogr.ToString();
        }
    }
}
