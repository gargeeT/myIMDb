using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myIMDb.Data.ViewModels
{
    public class ActorVM
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public System.DateTime DOB { get; set; }
        public string Bio { get; set; }
    }
}
