using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeProject.Models
{
    public class Anime
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Episodes { get; set; }
        public Adaptation Adaptation { get; set; }
        public AiringDay AiringDay { get; set; }
        public string PictureURL { get; set; }

        public virtual Month Month { get; set; }
        public int  MonthID { get; set;  }
        //creates relations 
    }
}
