using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = ToDoList.Domain.Entities.Task;

namespace ToDoList.Data.DbContexts
{
    public class ToDoContext : DbContext
    {
        public ToDoContext() : base("name=ToDoList")
        {

        }

        public DbSet<Task> Task { get; set; }
    }
}
