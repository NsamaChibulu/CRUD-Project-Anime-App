using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeProject.Interfaces
{
    public interface IRepositoryWrapper
    {
        IMonthRepository Months { get; }
        IAnimeRepository Animes { get;  }
        void Save();
        void UpdateMonth(IUpdateMonth @object, Guid guid);
    }
}
