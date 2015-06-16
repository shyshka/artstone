using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Artstone.Models
{
    public class Monument
    {
        public string Name { get; set; }
        public string ImageFilePath { get; set; }

        public Monument(string imageFilePath)
        {
            ImageFilePath = imageFilePath;
        }
    }
}