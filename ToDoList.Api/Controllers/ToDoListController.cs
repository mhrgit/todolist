using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDoList.Domain.Entities;
using ToDoList.Domain.Interfaces;
using Task = ToDoList.Domain.Entities.Task;

namespace ToDoList.Api.Controllers
{
    public class ToDoListController : ApiController
    {
        private readonly IRepository _repo;

        public ToDoListController(IRepository repo)
        {
            _repo = repo;
        }


        public IEnumerable<string> GetAll()
        {
            return new string[] {"Hello", "Merhaba"};
        }

        public Task GetTask()
        {
            return _repo.GetById(1);
        }
    }
}
