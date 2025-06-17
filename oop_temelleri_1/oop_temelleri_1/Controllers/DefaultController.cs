using oop_temelleri_1.Ornekler;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace oop_temelleri_1.Controllers
{
    //sınıf
    public class DefaultController: Controller
    {
        //void islemler()
        //{
        //    Class1 c = new Class1(); //Class1 yukarida tanimlanmazsa calismaz ctrl . ile tanımla
        //    c.topla();

        //}

        //metotlar ayni seyi 1000 kere yazmanin onune geciyor
        void message()
        {
            ViewBag.m1 = "bu bir core projesi"; //controllerdan viewe seyler tasimak icin
            ViewBag.m2 = "hosgeldin"; 
        }
        
        //tasarım icin
        public IActionResult Index() 
        {
            message();
            return View(); 
        }

        public IActionResult Urunler()
        { 
            message();
            return View();
        }

        public IActionResult Musteriler()
        {
            return View();

        }


     
    }
}
