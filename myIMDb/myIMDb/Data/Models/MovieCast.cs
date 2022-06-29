using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myIMDb.Data.Models
{
    
    public class MovieCast
    {
      
        public int Id { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        
    }
}
