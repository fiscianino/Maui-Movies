using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMovies.Models
{
    public class TrendingMovies
    {
        public int page {  get; set; }
        public List<MovieResult> results { get; set; }
        public int total_pages { get; set; }
        public int total_results {  get; set; }
    }
}
