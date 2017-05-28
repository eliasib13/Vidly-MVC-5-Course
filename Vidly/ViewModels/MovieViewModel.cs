using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieViewModel
    {
        public string ViewHeader { get; set; }
        public List<Movie> Movies { get; set; }
    }
}