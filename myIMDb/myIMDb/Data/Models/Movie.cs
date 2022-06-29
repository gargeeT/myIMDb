using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myIMDb.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime YearOfRelease { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }

        
        public int ProducerId { get; set; }

      
        public Producer Producer { get; set; }

        public List<MovieCast> MovieCasts { get; set; }
    }
}
