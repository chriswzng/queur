angular.module('starter')
.controller('LoginController', function($scope, $ionicModal, $state, Facebook) {

$scope.contact = {
    name: 'Mittens Cat2',
    info: 'Tap anywhere on the card to open the modal'
  }

getLoginStatus();

$scope.login = function() {
      // From now on you can use the Facebook service just as Facebook api says
      $scope.loggedIn = true;
      $state.go('getStarted');
    };

$scope.fbLogin = function() {
      // From now on you can use the Facebook service just as Facebook api says
      Facebook.login(function(response) {
        // Do something with response.
        var test = response;
      });
    };

function getLoginStatus() {
      Facebook.getLoginStatus(function(response) {
        if(response.status === 'connected') {
          $scope.loggedIn = true;
          $state.go('getStarted');
        } else {
          $scope.loggedIn = false;
        }
      });
    };

	});

