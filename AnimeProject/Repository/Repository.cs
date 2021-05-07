using AnimeProject.Data;
using AnimeProject.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AnimeProject.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected ApplicationDbContext RepositoryContext { get; set; }
        public Repository(ApplicationDbContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }
        public T Create(T item)
        {
            // <T> takes the generic class that is being passes through the Repository <T> and makes it a repository contetx
            // and add the 
            return RepositoryContext.Set<T>().Add(item).Entity;

        }

        public void Delete(T item)
        {
            RepositoryContext.Set<T>().Remove(item); // returns nothing 
        }

        public IEnumerable<T> FindAll()
        {
            return RepositoryContext.Set<T>().AsNoTracking();

        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        public T Update(T item)
        {
            return RepositoryContext.Set<T>().Update(item).Entity;
        }

        public T CreateAnime(T item)
        {
            return RepositoryContext.Set<T>().Add(item).Entity;
        }
    }
}
