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

        public ViewResult OgrenciDetay(int id)
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
            ViewData["ogrenci"] = ogr;
            ViewBag.student = ogr;
            return View();
        }
    }
}

//Controller->View veri taşıma
//ViewData:Bir koleksiyon yapısıdır. ViewData bir dictionary yapısıdır. Anahtar ve değer çiftlerinden oluşur.

//ViewBag: Arka planda ViewData koleksiyonunu kullanan,dynamic yapıda bir veri taşıma yapısıdır.

//ViewModel
