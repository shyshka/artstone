using Artstone.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Artstone.Controllers
{
    public class SingleController : Controller
    {
        public ActionResult Index()
        {
            var model = new SingleModel();
            string[] lstPhotos = Directory.GetFiles(Server.MapPath("~/Images/Single"));
            foreach (var item in lstPhotos)
                model.SliderPictures.Add(new Monument(item));
            return View(model);
        }
    }
}
