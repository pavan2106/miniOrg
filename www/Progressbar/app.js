angular.module('starter', ['ionic', 'starter.controllers'])

.run(function($ionicPlatform) {
  $ionicPlatform.ready(function() {
    if(window.StatusBar) {
      StatusBar.styleDefault();
    }
  });
})

.config(function($stateProvider, $urlRouterProvider) {
  $stateProvider

    .state('home', {
        url: '/home',
        templateUrl: 'home.html',
        controller: 'HomeController'
    })

    .state('second', {
        url: '/second',
        templateUrl: 'secondview.html',
        controller: 'SecondController'
    });
    
  // if none of the above states are matched, use this as the fallback
  $urlRouterProvider.otherwise('/home');
});
