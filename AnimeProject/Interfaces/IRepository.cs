using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AnimeProject.Interfaces
{
    public interface IRepository<T> // will take in aything you put it.Here, you should be able to do the following.
    {
        IEnumerable<T> FindAll();
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression); // memeber delegates 
        T Create(T item);
        T Update(T item);
        T CreateAnime(T item);

        void Delete(T item);


    }
}
