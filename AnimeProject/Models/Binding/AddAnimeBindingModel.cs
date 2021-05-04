using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeProject.Models.Binding
{
    public class AddAnimeBindingModel
    {
        public string Name { get; set; }

        public int Episodes { get; set; }
        public Adaptation Adaptation { get; set; }
        public AiringDay AiringDay { get; set; }
        public int MonthID { get; set; }

        
    }
}
