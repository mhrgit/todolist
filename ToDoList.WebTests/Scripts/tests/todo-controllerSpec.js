describe('Todo controller', function() {

    var $controllerConstructor;

    beforeEach(module('todoApp'));

    beforeEach(inject(function($controller) {
        $controllerConstructor = $controller;
    }));

    it('should call getTasks method of the service when getAll is called in controller',
        inject(function (TasksService) {

        var todoController = $controllerConstructor('TodoCtrl',
        { TasksService: TasksService });

        spyOn(TasksService, 'getTasks').and.callThrough();
        todoController.getTasks();

        expect(TasksService.getTasks).toHaveBeenCalled();
        }));

    it('should call addTask method of the service when addTask is called in controller',
    inject(function (TasksService) {

        var todoController = $controllerConstructor('TodoCtrl',
        { TasksService: TasksService });

        spyOn(TasksService, 'addTask').and.callThrough();
        todoController.addTask();

        expect(TasksService.addTask).toHaveBeenCalled();
    }));
});