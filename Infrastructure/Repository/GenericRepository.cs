using Application.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> _table;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _table.AsEnumerable().ToList();
            
        }

        public T GetById(object id)
        {
             return _table.Find(id);
        }

        public void Insert(T entity)
        {
            _table.Add(entity);
        }

        public void Update(T entity)
        {
            _table.Attach(entity);
            _context.Entry(entity).State =  EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = GetById(id);
            _table.Remove(existing);
        }
    }
}
