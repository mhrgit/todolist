using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ToDoList.Domain.Interfaces;
using Task = ToDoList.Domain.Entities.Task;

namespace ToDoList.Api.Tests
{
    public class MockedRepository : IRepository
    {
        private IList<Task> Context { get; set; }

        public MockedRepository()
        {
            Context = new List<Task>();
            Context.Add(new Task { Id = 1, Name = "Go to swimming"});
            Context.Add(new Task { Id = 2, Name = "Go to shopping" });
            Context.Add(new Task { Id = 3, Name = "Go to cinema" });
        }

        public IEnumerable<Task> GetAll()
        {
            return Context;
        }

        public Task GetById(int id)
        {
            return Context.FirstOrDefault(i => i.Id == id);
        }

        public void Add(Task task)
        {
            Context.Add(task);
        }

        public void Update(Task task)
        {
            throw new NotImplementedException();
        }

        public void Delete(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
