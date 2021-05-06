using AnimeProject.Data;
using AnimeProject.Interfaces;
using AnimeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeProject.Repository
{
    public class AnimeRepository : Repository<Anime>, IAnimeRepository
    {
        public AnimeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}

