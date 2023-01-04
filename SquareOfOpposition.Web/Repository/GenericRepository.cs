using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.EntityFrameworkCore;
using SquareOfOpposition.Web.Data;
using SquareOfOpposition.Web.Interfaces;
using System.Linq.Expressions;

namespace SquareOfOpposition.Web.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly SquareOfOppositionDbContext _context;
        public GenericRepository(SquareOfOppositionDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeExpressions)
        {
            IQueryable<T> set = _context.Set<T>();

            foreach (var includeExpression in includeExpressions)
            {
                set = set.Include(includeExpression);
            }
            return set.ToList();
        }
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
