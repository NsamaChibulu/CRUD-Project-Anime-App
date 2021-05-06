using AnimeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeProject.Interfaces
{
    public interface IViewAnime
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Episodes { get; set; }
  
        public AiringDay AiringDay { get; set; }
     
    }
}
