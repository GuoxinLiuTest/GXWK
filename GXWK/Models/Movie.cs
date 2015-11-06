using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToyAppChina.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        [DataType(DataType.MultilineText)]
        public string Plot { get; set; }
    }
}
