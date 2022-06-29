using myIMDb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myIMDb.Data.ViewModels
{
    public class MovieVM
    {
        public string Name { get; set; }
        public DateTime YearOfRelease { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }

        public List<int> ActorIds { get; set; }

        public int producer_id { get; set; }


    }

    public class MovieWithActorsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime YearOfRelease { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }

        public List<string> ActorNames { get; set; }

        public string ProducerName { get; set; }


    }
}
