using AnimeProject.Data;
using AnimeProject.Interfaces;
using AnimeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeProject.Repository
{
    public class MonthRepository : Repository<Month>, IMonthRepository
    {
        public MonthRepository(ApplicationDbContext dbContext): base(dbContext)
        {

        }

        public Month FindConditionBy(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
