todoApp.controller('TodoCtrl', ['$window', 'TasksService', function($window, TasksService) {

        var todo = this;
        todo.title = 'You can add a task here';

        todo.task = {
            name: ''
        };

        todo.getTasks = function() {
            TasksService.getTasks()
                .then(function(result) {
                    todo.tasks = (result !== 'null') ? result : {};
                }, function() {
                    //
                });
        };

        todo.getTasks();

        todo.addTask = function(task) {
            TasksService.addTask(task)
                .then(function() {
                    todo.getTasks();
                    $window.location.href = '/#/tasks';
                })
                .catch(function(e) {
                    //
                })
                .finally(function() {
                    //
                });
        }

        todo.setCurrentTask = function(task) {
            todo.selectedTask = task;
        };
    }
]);