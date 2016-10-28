var todoApp = angular.module('todoApp', ['ui.router', 'ngMessages']);

todoApp.config(function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.otherwise("/tasks");

    $stateProvider
        .state('tasks', {
            url: "/tasks",
            templateUrl: "Views/Home/templates/todo.list.html",
            controller: "TodoCtrl",
            controllerAs: "todo"
        })
        .state('addTask', {
            url: "/add-task",
            templateUrl: "Views/Home/templates/todo.add.html",
            controller: "TodoCtrl",
            controllerAs: "todo"
        });
})