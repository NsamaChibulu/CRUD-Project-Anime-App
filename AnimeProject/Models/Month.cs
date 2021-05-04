using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeProject.Models
{
    public class Month
    {
        public int ID { get; set; }
        public Date Date { get; set; }
        public int Year { get; set; }

        public virtual List<Anime> Animes { get; set;  }

      
    }
}
