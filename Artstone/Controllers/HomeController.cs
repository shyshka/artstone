using Artstone.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Artstone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult IndexNova()
        {
            return View();
        }

        public ActionResult Index()
        {
            Random rnd = new Random();
            string[] lstPhotos = Directory.GetFiles(Server.MapPath("~/Images/Single"));

            HomeModel model = new HomeModel();
            for (int i = 0; i < 10; i++)
            {
                int rndVal = rnd.Next(lstPhotos.Length);
                model.SliderPictures.Add(new Monument(lstPhotos[rndVal]));
            }
            return View(model);
        }
    }
}
