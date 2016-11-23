using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using ToDoList.Api.Controllers;
using ToDoList.Data.Repositories;
using ToDoList.Domain.Interfaces;
using Task = ToDoList.Domain.Entities.Task;

namespace ToDoList.Api.Tests
{
    [TestFixture]
    public class ToDoListControllerTests
    {        
        [Test]
        public void Controller_Should_Return_Everything_When_GetAll_Method_Called()
        {
            var controller = new ToDoListController(new MockedRepository());

            Assert.AreEqual(3, controller.GetAll().Count());
        }

        [Test]
        public void Controller_Should_Return_Task_When_Get_Method_Called()
        {
            var controller = new ToDoListController(new MockedRepository());

            Assert.AreEqual(2, controller.Get(2).Id);
        }

        [Test]
        public void Controller_Should_Add_New_Task_When_Add_Method_Called()
        {
            var controller = new ToDoListController(new MockedRepository());

            controller.Add(new Task {Id=4, Name = "Play football"});

           Assert.AreEqual(4, controller.GetAll().Count());
        }
    }
}
