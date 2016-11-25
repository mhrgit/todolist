describe('Tasks service', function () {

    beforeEach(module('todoApp'));

    var tasks = [
        { "id": 1, "name": "do something 1" },
        { "id": 2, "name": "do something 2" },
        { "id": 3, "name": "do something 3" },
        { "id": 4, "name": "do something 4" },
        { "id": 5, "name": "do something 5" }
    ];

    it('should return all tasks when getTasks called', inject(function (TasksService) {

        spyOn(TasksService, 'getTasks').and.callFake(function () {
            return tasks;
        });

        var numOfTasks = TasksService.getTasks().length;
        expect(numOfTasks).toEqual(5);
    }));

    it('should add task when addTask called', inject(function (TasksService) {

        spyOn(TasksService, 'addTask').and.callFake(function (task) {
            tasks.push(task);
        });

        TasksService.addTask({"id": 6, "name": "new task"});
        var numOfTasks = tasks.length;
        expect(numOfTasks).toEqual(6);
    }));


});