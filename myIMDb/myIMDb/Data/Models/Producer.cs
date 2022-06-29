using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myIMDb.Data.Models
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DOB { get; set; }
        public string Bio { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
