using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myIMDb.Data.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public System.DateTime DOB { get; set; }
        public string Bio { get; set; }

        public List<MovieCast> MovieCasts { get; set; }

    }
}
