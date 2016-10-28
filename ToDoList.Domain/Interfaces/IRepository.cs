using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = ToDoList.Domain.Entities.Task;

namespace ToDoList.Domain.Interfaces
{
    public interface IRepository
    {
        IEnumerable<Task> GetAll();
        Task GetById(int id);
        void Add(Task task);
        void Update(Task task);
        void Delete(Task task);

    }
}
