angular.module('starter.controllers', [])

.controller('HomeController', function($scope, $state, $interval) {
  
  $scope.progressval = 0;
  $scope.stopinterval = null;
  
  $scope.updateProgressbar = function()
  {
    startprogress();
    
  }
  
  function startprogress()
  {
    $scope.progressval = 0;
    
    if ($scope.stopinterval)
    {
      $interval.cancel($scope.stopinterval);
    }
    
    $scope.stopinterval = $interval(function() {
          $scope.progressval = $scope.progressval + 1;
           if( $scope.progressval >= 100 ) {
                 $interval.cancel($scope.stopinterval);
                 $state.go('second');
                 return;
            }
     }, 100);
  }

  startprogress();
  
})

.controller('SecondController', function($scope) {
  
});