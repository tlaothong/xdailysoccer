﻿module starter.sidemenu {
    'use strict';

    class SideMenuController {

        private isLogedin: boolean;

        static $inject = ['$scope', '$timeout', '$location', '$ionicModal', 'Azureservice', 'starter.shared.AccountManagementService'];
        constructor(private $scope,
            private $timeout: ng.ITimeoutService,
            private $location: ng.ILocationService,
            private $ionicModal,
            private Azureservice: any,
            private AccountManagementService: starter.shared.AccountManagementService) {

            this.$ionicModal.fromTemplateUrl('templates/Accounts/TieFacebookPopup.html',
                {
                    scope: $scope,
                    animation: 'slide-in-up'
                }).then(function (modal): void { $scope.TieFacebookPopup = modal; });
        }

        public LoginWithFacebookPopup(): void {
            this.$scope.TieFacebookPopup.show();
        }

        public LoginWithFacebook(): void {
            this.$scope.TieFacebookPopup.hide();
            this.AccountManagementService.TieFacebook();
        }

        public Logout(): void {
            this.AccountManagementService.Logout();
            this.$location.path('/account/login');
        }

        public IsLogedIn(): boolean {
            var accountInfo = this.AccountManagementService.GetAccountInformation();
            var isLogedIn = accountInfo.OAuthId != null;
            return isLogedIn;
        }
    }

    angular
        .module('starter.sidemenu', [])
        .controller('starter.sidemenu.SideMenuController', SideMenuController);
}