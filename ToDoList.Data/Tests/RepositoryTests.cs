using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using ToDoList.Data.Repositories;
using ToDoList.Domain.Interfaces;
using Task = ToDoList.Domain.Entities.Task;

namespace ToDoList.Data.Tests
{
    [TestFixture]
    public class RepositoryTests
    {        
        [Test]
        public void Repository_Should_Return_Everything_When_GetAll_Method_Called()
        {
            var list = new List<Task>
            {
                new Task {Id = 1, Name = "Go to swimming"},
                new Task {Id = 2, Name = "Go to shopping"},
                new Task {Id = 3, Name = "Go to cinema"}
            };

            var mock = new Mock<IRepository>();
            mock.Setup(x => x.GetAll()).Returns(list);
            Assert.AreEqual(mock.Object.GetAll(), list);
        }

        [Test]
        public void Repository_Should_Return_Task_When_GetById_Method_Called()
        {         
            var list = new List<Task>
            {
                new Task {Id = 1, Name = "Go to swimming"},
                new Task {Id = 2, Name = "Go to shopping"},
                new Task {Id = 3, Name = "Go to cinema"}
            };

            var mockRepo = new Mock<IRepository>();

            mockRepo.Setup(r => r.GetById(It.IsAny<int>())).Returns((int i) => list.Single(x => x.Id == i));

            var task = mockRepo.Object.GetById(2);

            Assert.IsNotNull(task); 
            Assert.AreEqual("Go to shopping", task.Name); 
        }

        [Test]
        public void Repository_Should_Add_New_Task_When_Add_Method_Called()
        {
            var mockRepo = new MockedRepository();

            mockRepo.Add(new Task {Id=4, Name = "Play football"});

           Assert.AreEqual(4, mockRepo.GetAll().Count());
        }
    }
}
