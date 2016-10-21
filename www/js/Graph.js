var app = angular.module('starter', ['ionic','chart.js']);

app.controller('ExampleController', function($scope) {
  $scope.graph = {};
  $scope.graph.data = [
    //Awake
    [160, 15, 201, 121, 161, 121, 81],
    //Asleep
    [10, 19, 41, 112, 18, 112, 1014]
  ];


  $scope.graph.labels = ['Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'];
  $scope.graph.series = ['Awake', 'Asleep'];
   $scope.graph.options = {
    animation: false
  }
    $scope.graph.legend = true;
});
