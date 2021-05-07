using AnimeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthsConsole
{
    public class AddAnime
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Episodes { get; set; }
        public Adaptation Adaptation { get; set; }
        public AiringDay AiringDay { get; set; }
        public string PictureURL { get; set; }

        public virtual Month Month { get; set; }
        public int MonthID { get; set; }
        //creates relations 
    }
}
