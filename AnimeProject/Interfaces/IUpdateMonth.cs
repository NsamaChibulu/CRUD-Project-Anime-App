using AnimeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeProject.Interfaces
{
    public interface IUpdateMonth
    {
       
        public Date Date { get; set; }
        public int Year { get; set; }
    }
}
