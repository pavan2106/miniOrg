//var app = angular.module('plunker', ['chart.js']);
var app = angular.module('starter', ['ionic','chart.js']);
app.controller('ExampleController', function($scope) {
 /*  $scope.colors = ['#45b7cd', '#ff6384', '#ff8e72'];
  $scope.graph = {};
  $scope.graph.visible = false;
   
  $scope.showGraph = function(yesOrNo) {
    $scope.graph.visible = yesOrNo;
  }
  
  $scope.graph.data = [[1, 2, 3, 4, 5, 6, 7, 8]];
  $scope.graph.labels = ['hoi', 'doei', 'hallo', 'hee', 'hoi', 'doei', 'hallo', 'hee'];
  $scope.graph.options = {
    animation: true
  };
  $scope.graph.series = ['Series']

  $scope.graph.legend = true;*/
   $scope.graph = {};
  $scope.graph.data = [
    //Awake
    [16, 15, 20, 12, 16, 12, 8],
    //Asleep
    [10, 19, 41, 12, 18, 12, 14]
  ];
   $scope.graph.data1 = [ 116,120,123,121,134,156,166];
$scope.graph.labels1 = ['Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'];

  $scope.graph.labels = ['Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'];
  $scope.graph.series = ['Awake', 'Asleep'];
   $scope.graph.options = {
    animation: false
  }
    $scope.graph.legend = true;
});
