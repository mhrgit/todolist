using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.DbContexts;
using ToDoList.Domain.Interfaces;
using Task = ToDoList.Domain.Entities.Task;

namespace ToDoList.Data.Repositories
{
    public class Repository : IRepository
    {
        private readonly ToDoContext _context;
        private DbSet<Task> _dbSet;

        public Repository()
        {
            _context = new ToDoContext();
            _dbSet = _context.Set<Task>();
        }

        public IQueryable<Task> GetAll()
        {
            return _dbSet;
        }

        public Task GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(Task task)
        {
            DbEntityEntry entry = _context.Entry(task);

            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                _dbSet.Add(task);
            }
        }

        public void Update(Task task)
        {
            DbEntityEntry entry = _context.Entry(task);

            if (entry.State == EntityState.Detached)
            {
                _dbSet.Attach(task);
            }
            entry.State = EntityState.Modified;
        }

        public void Delete(Task task)
        {
            DbEntityEntry entry = _context.Entry(task);

            if (entry.State != EntityState.Deleted)
            {
                entry.State = EntityState.Deleted;
            }
            else
            {
                _dbSet.Attach(task);
                _dbSet.Remove(task);
            }
        }
    }
}
