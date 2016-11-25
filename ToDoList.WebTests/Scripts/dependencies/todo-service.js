todoApp.constant('TASKS_ENDPOINT', 'http://localhost:51001/api/todolist/')
    .factory('TasksService', function($http, $q, TASKS_ENDPOINT) {

        function extract(result) {
            return result.data;
        }

        function getTasks() {
            return $http.get(TASKS_ENDPOINT + 'getAll').then(extract);
        }

        function addTask(task) {
            return $http.post(TASKS_ENDPOINT + 'add', task).then(extract);
        };

        return {
            getTasks: getTasks,
            addTask: addTask    
        }
    });