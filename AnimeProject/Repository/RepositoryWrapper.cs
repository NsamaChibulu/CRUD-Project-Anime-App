using AnimeProject.Data;
using AnimeProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeProject.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        ApplicationDbContext _repoContext;
        public RepositoryWrapper(ApplicationDbContext repoContext)
        {
            _repoContext = repoContext;
        }
        IMonthRepository _months;

        IAnimeRepository _animes;

        public IAnimeRepository Animes
        {
            get
            {
                if (_animes == null)
                {
                    _animes = new AnimeRepository(_repoContext);
                }
                return _animes;

            }
        }
        public IMonthRepository Months
        {
            get
            {
                if (_months == null)
                {
                    _months = new MonthRepository(_repoContext);
                }
                return _months;

            }
        }

      void IRepositoryWrapper.Save()
        {
            _repoContext.SaveChanges();
        }

        public void UpdateMonth(IUpdateMonth @object, Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
