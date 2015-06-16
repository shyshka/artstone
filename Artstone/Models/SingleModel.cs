using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Artstone.Models
{
    public class SingleModel
    {
        public List<Monument> SliderPictures { get; set; }

        public SingleModel()
        {
            SliderPictures = new List<Monument>();            
        }
    }
}