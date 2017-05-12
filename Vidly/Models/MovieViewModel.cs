using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MovieViewModel
    {
        public string ViewHeader { get; set; }
        public List<Movie> Movies { get; set; }
    }
}