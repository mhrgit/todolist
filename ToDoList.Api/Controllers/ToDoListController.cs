using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDoList.Domain.Entities;
using ToDoList.Domain.Interfaces;
using Task = ToDoList.Domain.Entities.Task;
using System.Web.Http.Cors;

namespace ToDoList.Api.Controllers
{

    public class ToDoListController : ApiController
    {
        private readonly IRepository _repo;

        public ToDoListController(IRepository repo)
        {
            _repo = repo;
        }

        public Task Get(int id)
        {
            return _repo.GetById(id);
        }

        public IEnumerable<Task> GetAll()
        {
            return _repo.GetAll();
        }

        public void Add([FromBody]Task task)
        {
            _repo.Add(task);
        }

        public void Update(int id, [FromBody]Task task)
        {
            _repo.Update(task);
        }

        public void Delete(int id)
        {
        }


    }
}
