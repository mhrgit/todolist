namespace ToDoList.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Task = Domain.Entities.Task;

    internal sealed class Configuration : DbMigrationsConfiguration<DbContexts.ToDoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DbContexts.ToDoContext context)
        {

            var task = new Task {Name = "Wash clothes"};
            context.Task.AddOrUpdate(task);
        }
    }
}
