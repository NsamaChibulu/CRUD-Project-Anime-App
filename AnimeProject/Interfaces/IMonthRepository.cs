using AnimeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeProject.Interfaces
{
    public interface IMonthRepository : IRepository<Month>
    {
        Month FindConditionBy(Func<object, bool> p);
    }
}
