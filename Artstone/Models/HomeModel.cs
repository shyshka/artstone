using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Artstone.Models
{
    public class HomeModel
    {
        public List<Monument> SliderPictures { get; set; }

        public HomeModel()
        {
            SliderPictures = new List<Monument>();            
        }
    }
}