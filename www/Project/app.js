var app = angular.module('plunker', ['chart.js']);

app.controller('MainCtrl', function($scope) {
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

  $scope.graph.legend = true;
});
