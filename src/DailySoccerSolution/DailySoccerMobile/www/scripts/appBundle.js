// angular.module is a global place for creating, registering and retrieving Angular modules
// 'starter' is the name of this angular module example (also set in a <body> attribute in index.html)
// the 2nd parameter is an array of 'requires'
// 'starter.controllers' is found in controllers.js
angular.module('starter', ['ionic', 'ionic.service.core', 'azure-mobile-service.module', 'starter.controllers', 'starter.shared', 'starter.account', 'starter.match', 'starter.reward', 'starter.sidemenu', 'starter.history', 'bhResponsiveImages', 'starter.ticket'])
    .constant('AzureMobileServiceClient', {
    API_URL: 'https://dailysoccer.azurewebsites.net',
    API_KEY: 'https://dailysoccerb2b9cb00dad1424394487af38c61ca1e.azurewebsites.net'
})
    .run(function ($ionicPlatform) {
    $ionicPlatform.ready(function () {
        // Hide the accessory bar by default (remove this to show the accessory bar above the keyboard
        // for form inputs)
        if (window.cordova && window.cordova.plugins.Keyboard) {
            cordova.plugins.Keyboard.hideKeyboardAccessoryBar(true);
            cordova.plugins.Keyboard.disableScroll(true);
        }
        if (window.StatusBar) {
            // org.apache.cordova.statusbar required
            window.StatusBar.styleDefault();
        }
        // kick off the platform web client
        Ionic.io();
    });
})
    .config(function ($stateProvider, $urlRouterProvider) {
    $stateProvider
        .state('app', {
        url: '/app',
        abstract: true,
        templateUrl: 'templates/menu.html',
        controller: 'AppCtrl'
    })
        .state('app.search', {
        url: '/search',
        views: {
            'menuContent': {
                templateUrl: 'templates/search.html'
            }
        }
    })
        .state('app.browse', {
        url: '/browse',
        views: {
            'menuContent': {
                templateUrl: 'templates/browse.html'
            }
        }
    })
        .state('app.playlists', {
        url: '/playlists',
        views: {
            'menuContent': {
                templateUrl: 'templates/playlists.html',
                controller: 'PlaylistsCtrl'
            }
        }
    })
        .state('app.single', {
        url: '/playlists/:playlistId',
        views: {
            'menuContent': {
                templateUrl: 'templates/playlist.html',
                controller: 'PlaylistCtrl'
            }
        }
    })
        .state('account', {
        url: '/account',
        abstract: true,
        cache: false,
        templateUrl: 'templates/_fullpageTemplate.html',
        controller: 'starter.account.AccountController as accountCtrl'
    })
        .state('account.login', {
        url: '/login',
        views: {
            'MainContent': {
                templateUrl: 'templates/Accounts/Login.html',
            }
        }
    })
        .state('account.tiefacebook', {
        url: '/tiefacebook',
        views: {
            'MainContent': {
                templateUrl: 'templates/Accounts/SyncData.html',
            }
        }
    })
        .state('account.favorite', {
        url: '/favorite',
        views: {
            'MainContent': {
                templateUrl: 'templates/Accounts/Favorite.html',
            }
        }
    })
        .state('matches', {
        url: '/matches',
        abstract: true,
        cache: false,
        templateUrl: 'templates/_matchTemplate.html',
        controller: 'starter.match.MatchController as matchCtrl'
    })
        .state('matches.todaymatches', {
        url: '/todaymatches',
        views: {
            'MainContent': {
                templateUrl: 'templates/Matches/TodayMatches.html',
            }
        }
    })
        .state('rewards', {
        url: '/rewards',
        abstract: true,
        templateUrl: 'templates/_rewardTemplate.html',
        controller: 'starter.reward.RewardController as rewardCtrl'
    })
        .state('rewards.rewards', {
        url: '/rewards',
        views: {
            'tab-rewards': {
                templateUrl: 'templates/Rewards/Rewards.html',
            }
        }
    })
        .state('rewards.myrewards', {
        url: '/myrewards',
        views: {
            'tab-myrewards': {
                templateUrl: 'templates/Rewards/MyRewards.html',
            }
        }
    })
        .state('rewards.rewardwinner', {
        url: '/rewardwinner',
        views: {
            'tab-rewardwinner': {
                templateUrl: 'templates/Rewards/RewardWinner.html',
            }
        }
    })
        .state('history', {
        url: '/history',
        abstract: true,
        templateUrl: 'templates/_basicTemplate.html',
        controller: 'starter.history.HistoryController as historyCtrl'
    })
        .state('history.historybymonth', {
        url: '/historybymonth',
        views: {
            'MainContent': {
                templateUrl: 'templates/Matches/HistoryByMonth.html',
            }
        }
    })
        .state('history.historybyday', {
        url: '/historybyday',
        views: {
            'MainContent': {
                templateUrl: 'templates/Matches/HistoryByDay.html',
            }
        }
    })
        .state('ticket', {
        url: '/ticket',
        abstract: true,
        templateUrl: 'templates/_basicTemplate.html',
        controller: 'starter.ticket.TicketController as sidemenuCtrl'
    })
        .state('ticket.buyticket', {
        url: '/buyticket',
        views: {
            'MainContent': {
                templateUrl: 'templates/Rewards/BuyTicket.html',
            }
        }
    })
        .state('buyticketcompleted', {
        url: '/buyticketcompleted',
        abstract: true,
        templateUrl: 'templates/_fullpageTemplate.html',
    })
        .state('buyticketcompleted.buyticketcompleted', {
        url: '/buyticketcompleted/:remainingPoints/:expiredDate',
        views: {
            'MainContent': {
                templateUrl: 'templates/Rewards/BuyTicketCompleted.html',
                controller: 'starter.ticket.TicketController as ticketCtrl'
            }
        }
    })
        .state('verify', {
        url: '/verify',
        abstract: true,
        templateUrl: 'templates/_basicTemplate.html',
        controller: 'starter.account.AccountController as accountCtrl'
    })
        .state('verify.verifyphonenumber', {
        url: '/verifyphonenumber/:buyTicketAmount',
        views: {
            'MainContent': {
                templateUrl: 'templates/Accounts/VerifyPhoneNumber.html',
                controller: 'starter.account.AccountController as accountCtrl'
            }
        }
    })
        .state('verify.verifycode', {
        url: '/verifycode/:phoneNumber/:buyTicketAmount',
        views: {
            'MainContent': {
                templateUrl: 'templates/Accounts/VerifyCode.html',
                controller: 'starter.account.AccountController as accountCtrl'
            }
        }
    })
        .state('underconstruction', {
        url: '/underconstruction',
        abstract: true,
        templateUrl: 'templates/_basicTemplate.html'
    })
        .state('underconstruction.underconstruction', {
        url: '/underconstruction',
        views: {
            'MainContent': {
                templateUrl: 'templates/UnderConstruction.html',
            }
        }
    })
        .state('syncdata', {
        url: '/syncdata',
        abstract: true,
        templateUrl: 'templates/_fullpageTemplate.html',
    })
        .state('syncdata.syncdata', {
        url: '/syncdata',
        views: {
            'MainContent': {
                templateUrl: 'templates/Accounts/SyncData.html',
            }
        }
    });
    // if none of the above states are matched, use this as the fallback
    //$urlRouterProvider.otherwise('/app/playlists');
    $urlRouterProvider.otherwise('/account/login');
});
angular.module('starter.controllers', [])
    .controller('AppCtrl', function ($scope, $ionicModal, $timeout) {
    $scope.groups = [];
    for (var i = 0; i < 2; i++) {
        $scope.groups[i] = {
            name: i,
            items: []
        };
    }
    $scope.toggleGroup = function (group) {
        if ($scope.isGroupShown(group)) {
            $scope.shownGroup = null;
        }
        else {
            $scope.shownGroup = group;
        }
    };
    $scope.isGroupShown = function (group) {
        return $scope.shownGroup === group;
    };
    // With the new view caching in Ionic, Controllers are only called
    // when they are recreated or on app start, instead of every page change.
    // To listen for when this page is active (for example, to refresh data),
    // listen for the $ionicView.enter event:
    //$scope.$on('$ionicView.enter', function(e) {
    //});
    // Form data for the login modal
    $scope.loginData = {};
    // Create the login modal that we will use later
    $ionicModal.fromTemplateUrl('templates/login.html', {
        scope: $scope
    }).then(function (modal) {
        $scope.modal = modal;
    });
    // Triggered in the login modal to close it
    $scope.closeLogin = function () {
        $scope.modal.hide();
    };
    // Open the login modal
    $scope.login = function () {
        $scope.modal.show();
    };
    // Perform the login action when the user submits the login form
    $scope.doLogin = function () {
        console.log('Doing login', $scope.loginData);
        // Simulate a login delay. Remove this and replace with your login
        // code if using a login system
        $timeout(function () {
            $scope.closeLogin();
        }, 1000);
    };
})
    .controller('PlaylistsCtrl', function ($scope, Azureservice) {
    //var user = Ionic.User.current();
    //alert(user.get('name'));
    //Azureservice.invokeApi('Account/CreateNewGuess', {
    //        method: 'get'
    //})
    //.then(function (response) {
    //    console.log('Here is my response object');
    //    alert(response.userId)
    //}, function (err) {
    //    console.error('Azure Error: ' + err);
    //});
    $scope.playlists = [
        { title: 'Reggae', id: 1 },
        { title: 'Chill', id: 2 },
        { title: 'Dubstep', id: 3 },
        { title: 'Indie', id: 4 },
        { title: 'Rap', id: 5 },
        { title: 'Cowbell', id: 6 }
    ];
})
    .controller('PlaylistCtrl', function ($scope, $stateParams) {
});
var starter;
(function (starter) {
    var account;
    (function (account) {
        'use strict';
        var AccountController = (function () {
            function AccountController($scope, $stateParams, $timeout, $location, accountSvc, Azureservice, AccountManagementService, ticketSvc) {
                this.$scope = $scope;
                this.$stateParams = $stateParams;
                this.$timeout = $timeout;
                this.$location = $location;
                this.accountSvc = accountSvc;
                this.Azureservice = Azureservice;
                this.AccountManagementService = AccountManagementService;
                this.ticketSvc = ticketSvc;
                this._selectedTeamId = -1;
                if (this.$stateParams.buyTicketAmount) {
                    this._buyTicketAmount = this.$stateParams.buyTicketAmount;
                }
                this.checkLocalStorageAccount();
                //Clear local storage for test only!
                //this.AccountManagementService.ClearGuestData();
            }
            AccountController.prototype.GetAllLeague = function () {
                var _this = this;
                this.accountSvc.GetAllLeague()
                    .then(function (respond) {
                    _this.updateDisplayLeague(respond.Leagues);
                    console.log('Get all league completed.');
                });
            };
            AccountController.prototype.updateDisplayLeague = function (leagues) {
                this._allLeague = leagues;
                //Hack: Not fliter yet
                this.DisplayLeague = this._allLeague;
                console.log('# Update league completed.');
            };
            AccountController.prototype.checkLocalStorageAccount = function () {
                var user = Ionic.User.current();
                if (user.id && user.id != 'empty') {
                    this.$location.path('/matches/todaymatches');
                }
                else {
                    var isSkiped = user.get('isSkiped');
                    if (isSkiped) {
                        this.isHideSkipButton = true;
                    }
                }
            };
            AccountController.prototype.SkipLogin = function () {
                // TODO: Login with guest
                this.AccountManagementService.CreateNewGuestUser();
            };
            ;
            AccountController.prototype.LoginWithFacebook = function () {
                this.AccountManagementService.LoginWithFacebook();
            };
            ;
            AccountController.prototype.TieFacbookWithFacebookData = function () {
                this.AccountManagementService.TieFacbookWithFacebookData();
            };
            AccountController.prototype.TieFacbookWithLocalData = function () {
                this.AccountManagementService.TieFacbookWithLocalData();
            };
            AccountController.prototype.SelectFavoriteTeam = function (TeamId) {
                this._selectedTeamId = TeamId;
                console.log('Set favorite team completed.');
            };
            AccountController.prototype.SetFavoriteTeam = function () {
                var user = Ionic.User.current();
                if (this._selectedTeamId > -1) {
                    var favoriteTeam = new account.SetFavoriteTeamRequest();
                    favoriteTeam.UserId = user.id;
                    favoriteTeam.SelectedTeamId = this._selectedTeamId;
                    this.accountSvc.SetFavoriteTeam(favoriteTeam);
                    console.log('Send favorite team completed.');
                }
                else {
                    console.log('Skip to send favorite team completed.');
                }
                this.$location.path('/matches/todaymatches');
                user.set('isSetFavoriteTeam', 'true');
                user.save();
            };
            AccountController.prototype.ShowFacebookData = function () {
                this.facebookPoint = this.AccountManagementService.facebookPoint;
                this.localPoint = this.AccountManagementService.localPoint;
            };
            AccountController.prototype.SendRequestVerifyPhoneNumber = function (phoneNumber, isRequireReload) {
                var _this = this;
                if (isRequireReload === void 0) { isRequireReload = true; }
                console.log('Call SendRequestVerifyPhoneNumber');
                var userId = this.AccountManagementService.GetAccountInformation().SecretCode;
                var areArgumentValid = phoneNumber != null && userId != null;
                if (!areArgumentValid)
                    return;
                console.log('Begin SendRequestVerifyPhoneNumber');
                var request = new account.RequestConfirmPhoneNumberRequest();
                request.UserId = userId;
                request.PhoneNo = phoneNumber;
                this.accountSvc.RequestConfirmPhoneNumber(request)
                    .then(function (respond) {
                    if (respond.IsSuccessed) {
                        console.log("#RequestConfirmPhoneNumber successed.");
                        if (isRequireReload) {
                            _this.$location.path('/verify/verifycode/' + respond.ForPhoneNumber + '/' + _this._buyTicketAmount);
                        }
                    }
                    else {
                        console.log("#RequestConfirmPhoneNumber failed.");
                    }
                });
            };
            AccountController.prototype.ConfirmPhoneNumber = function (verificationCode) {
                var _this = this;
                var userId = this.AccountManagementService.GetAccountInformation().SecretCode;
                if (verificationCode != null) {
                    var request = new account.ConfirmPhoneNumberRequest();
                    request.UserId = userId;
                    request.VerificationCode = verificationCode;
                    this.accountSvc.ConfirmPhoneNumber(request)
                        .then(function (respond) {
                        if (respond.IsSuccessed) {
                            _this.AccountManagementService.SetPhoneVerified();
                            var request = new starter.ticket.BuyTicketRequest();
                            request.UserId = userId;
                            request.Amount = _this._buyTicketAmount;
                            _this.ticketSvc.BuyTicket(request).
                                then(function (respond) {
                                if (respond.IsSuccessed) {
                                    _this.AccountManagementService.CurrentPoints = respond.AccountInfo.Points;
                                    _this.AccountManagementService.CurrentOrderedCoupon = respond.AccountInfo.CurrentOrderedCoupon;
                                    console.log('Buy ticket completed.');
                                    _this.$location.path('/buyticketcompleted/buyticketcompleted/' + respond.AccountInfo.Points + '/' + respond.RewardResultDate);
                                }
                                else {
                                    console.log('Buy ticket failed.');
                                    _this.$location.path('/ticket/buyticket');
                                }
                            });
                            console.log("#RequestVerificationCode successed.");
                        }
                        else {
                            console.log("#RequestVerificationCode failed.");
                        }
                    });
                }
            };
            AccountController.$inject = ['$scope', '$stateParams', '$timeout', '$location', 'starter.account.AccountServices', 'Azureservice', 'starter.shared.AccountManagementService', 'starter.ticket.TicketServices'];
            return AccountController;
        })();
        angular
            .module('starter.account', [])
            .controller('starter.account.AccountController', AccountController);
    })(account = starter.account || (starter.account = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var account;
    (function (account) {
        var AccountInformation = (function () {
            function AccountInformation() {
            }
            return AccountInformation;
        })();
        account.AccountInformation = AccountInformation;
        var CreateNewGuestRespond = (function () {
            function CreateNewGuestRespond() {
            }
            return CreateNewGuestRespond;
        })();
        account.CreateNewGuestRespond = CreateNewGuestRespond;
        var LeagueInformation = (function () {
            function LeagueInformation() {
            }
            return LeagueInformation;
        })();
        account.LeagueInformation = LeagueInformation;
        var GetAllLeagueRespond = (function () {
            function GetAllLeagueRespond() {
            }
            return GetAllLeagueRespond;
        })();
        account.GetAllLeagueRespond = GetAllLeagueRespond;
        var SetFavoriteTeamRequest = (function () {
            function SetFavoriteTeamRequest() {
            }
            return SetFavoriteTeamRequest;
        })();
        account.SetFavoriteTeamRequest = SetFavoriteTeamRequest;
        var RequestConfirmPhoneNumberRequest = (function () {
            function RequestConfirmPhoneNumberRequest() {
            }
            return RequestConfirmPhoneNumberRequest;
        })();
        account.RequestConfirmPhoneNumberRequest = RequestConfirmPhoneNumberRequest;
        var RequestConfirmPhoneNumberRespond = (function () {
            function RequestConfirmPhoneNumberRespond() {
            }
            return RequestConfirmPhoneNumberRespond;
        })();
        account.RequestConfirmPhoneNumberRespond = RequestConfirmPhoneNumberRespond;
        var ConfirmPhoneNumberRequest = (function () {
            function ConfirmPhoneNumberRequest() {
            }
            return ConfirmPhoneNumberRequest;
        })();
        account.ConfirmPhoneNumberRequest = ConfirmPhoneNumberRequest;
        var ConfirmPhoneNumberRespond = (function () {
            function ConfirmPhoneNumberRespond() {
            }
            return ConfirmPhoneNumberRespond;
        })();
        account.ConfirmPhoneNumberRespond = ConfirmPhoneNumberRespond;
    })(account = starter.account || (starter.account = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var account;
    (function (account) {
        'use strict';
        var AccountServices = (function () {
            function AccountServices(queryRemoteSvc) {
                this.queryRemoteSvc = queryRemoteSvc;
            }
            AccountServices.prototype.CreateNewGuest = function () {
                var requestUrl = "Account/CreateNewGuest";
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            AccountServices.prototype.GetAllLeague = function () {
                var requestUrl = "Favorite/GetAllLeagues";
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            AccountServices.prototype.SetFavoriteTeam = function (req) {
                var requestUrl = "Favorite/SetFavoriteTeam?userId=" + req.UserId + "&selectedTeamId=" + req.SelectedTeamId;
                this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            AccountServices.prototype.GetAccountBySecretCode = function (secretCode) {
                var requestUrl = "Account/GetAccountBySecretCode?secretCode=" + secretCode;
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            AccountServices.prototype.GetAccountByOAuthId = function (OAuthId) {
                var requestUrl = "Account/GetAccountByOAuthId?OAuthId=" + OAuthId;
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            AccountServices.prototype.CreateNewGuestWithFacebook = function (OAuthId) {
                var requestUrl = "Account/CreateNewGuestWithFacebook?OAuthId=" + OAuthId;
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            AccountServices.prototype.UpdateAccountWithFacebook = function (secretCode, OAuthId) {
                var requestUrl = "Account/UpdateAccountWithFacebook?secretCode=" + secretCode + "&OAuthId=" + OAuthId;
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            AccountServices.prototype.TieFacbookWithFacebookData = function (secretCode, OAuthId) {
                var requestUrl = "Account/TieFacbookWithFacebookData?secretCode=" + secretCode + "&OAuthId=" + OAuthId;
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            AccountServices.prototype.TieFacbookWithLocalData = function (secretCode, OAuthId) {
                var requestUrl = "Account/TieFacbookWithLocalData?secretCode=" + secretCode + "&OAuthId=" + OAuthId;
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            AccountServices.prototype.RequestConfirmPhoneNumber = function (request) {
                var requestUrl = "Account/RequestConfirmPhoneNumber?userId=" + request.UserId + "&phoneNo=" + request.PhoneNo;
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            AccountServices.prototype.ConfirmPhoneNumber = function (request) {
                var requestUrl = "Account/ConfirmPhoneNumber?userId=" + request.UserId + "&verificationCode=" + request.VerificationCode;
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            AccountServices.$inject = ['starter.shared.QueryRemoteDataService'];
            return AccountServices;
        })();
        account.AccountServices = AccountServices;
        angular
            .module('starter.account')
            .service('starter.account.AccountServices', AccountServices);
    })(account = starter.account || (starter.account = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var history;
    (function (history) {
        'use strict';
        var HistoryController = (function () {
            function HistoryController($scope, historySvc) {
                this.$scope = $scope;
                this.historySvc = historySvc;
                this.GetHistories();
            }
            HistoryController.prototype.GetHistories = function () {
                var _this = this;
                var user = Ionic.User.current();
                var data = new history.GetAllGuessHistoryRequest();
                data.UserId = user.id;
                this.historySvc.GetAllGuessHistory(data)
                    .then(function (respond) {
                    _this.HistoryInfo = respond;
                    var date = new Date(respond.CurrentDate.toString());
                    _this.Year = date.getFullYear();
                    console.log('Get all history completed.');
                });
            };
            HistoryController.prototype.GetHistoriesByMonth = function (month) {
                var _this = this;
                var user = Ionic.User.current();
                var data = new history.GetGuessHistoryByMonthRequest();
                data.UserId = user.id;
                data.Month = month;
                data.Year = this.Year;
                this.historySvc.GetGuessHistoryByMonth(data)
                    .then(function (respond) {
                    _this.HistoryByMonthInfo = respond;
                    console.log('Get all history by month completed.');
                    console.log(month);
                });
            };
            HistoryController.prototype.GetMonthString = function (month) {
                month -= 1;
                var monthString = new Date(this.Year, month);
                return monthString;
            };
            HistoryController.prototype.toggleGroup = function (group) {
                if (this.isGroupShown(group)) {
                    this.shownGroup = null;
                }
                else {
                    this.shownGroup = group;
                }
            };
            ;
            HistoryController.prototype.isGroupShown = function (group) {
                console.log(this.shownGroup == group);
                return this.shownGroup == group;
            };
            ;
            HistoryController.$inject = ['$scope', 'starter.history.HistoryServices'];
            return HistoryController;
        })();
        angular
            .module('starter.history', [])
            .controller('starter.history.HistoryController', HistoryController);
    })(history = starter.history || (starter.history = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var history;
    (function (history) {
        var MatchInformation = (function () {
            function MatchInformation() {
            }
            return MatchInformation;
        })();
        history.MatchInformation = MatchInformation;
        var TeamInformation = (function () {
            function TeamInformation() {
            }
            return TeamInformation;
        })();
        history.TeamInformation = TeamInformation;
        var GetAllGuessHistoryRequest = (function () {
            function GetAllGuessHistoryRequest() {
            }
            return GetAllGuessHistoryRequest;
        })();
        history.GetAllGuessHistoryRequest = GetAllGuessHistoryRequest;
        var GetAllGuessHistoryRespond = (function () {
            function GetAllGuessHistoryRespond() {
            }
            return GetAllGuessHistoryRespond;
        })();
        history.GetAllGuessHistoryRespond = GetAllGuessHistoryRespond;
        var GuessHistoryMonthlyInformation = (function () {
            function GuessHistoryMonthlyInformation() {
            }
            return GuessHistoryMonthlyInformation;
        })();
        history.GuessHistoryMonthlyInformation = GuessHistoryMonthlyInformation;
        var GetGuessHistoryByMonthRequest = (function () {
            function GetGuessHistoryByMonthRequest() {
            }
            return GetGuessHistoryByMonthRequest;
        })();
        history.GetGuessHistoryByMonthRequest = GetGuessHistoryByMonthRequest;
        var GetGuessHistoryByMonthRespond = (function () {
            function GetGuessHistoryByMonthRespond() {
            }
            return GetGuessHistoryByMonthRespond;
        })();
        history.GetGuessHistoryByMonthRespond = GetGuessHistoryByMonthRespond;
        var GuessHistoryDailyInformation = (function () {
            function GuessHistoryDailyInformation() {
            }
            return GuessHistoryDailyInformation;
        })();
        history.GuessHistoryDailyInformation = GuessHistoryDailyInformation;
    })(history = starter.history || (starter.history = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var history;
    (function (history) {
        'use strict';
        var HistoryServices = (function () {
            function HistoryServices(queryRemoteSvc) {
                this.queryRemoteSvc = queryRemoteSvc;
            }
            HistoryServices.prototype.GetAllGuessHistory = function (req) {
                var requestUrl = 'History/GetAllGuessHistory?UserId=' + req.UserId;
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            HistoryServices.prototype.GetGuessHistoryByMonth = function (req) {
                var requestUrl = 'History/GetGuessHistoryByMonth?UserId=' + req.UserId + '&year=' + req.Year + '&month=' + req.Month;
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            HistoryServices.$inject = ['starter.shared.QueryRemoteDataService'];
            return HistoryServices;
        })();
        history.HistoryServices = HistoryServices;
        angular
            .module('starter.history')
            .service('starter.history.HistoryServices', HistoryServices);
    })(history = starter.history || (starter.history = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var match;
    (function (match_1) {
        'use strict';
        var MatchController = (function () {
            function MatchController($scope, matchSvc, $location, $ionicModal, $ionicTabsDelegate, accountManagementSvc) {
                this.$scope = $scope;
                this.matchSvc = matchSvc;
                this.$location = $location;
                this.$ionicModal = $ionicModal;
                this.$ionicTabsDelegate = $ionicTabsDelegate;
                this.accountManagementSvc = accountManagementSvc;
                this.PastOneDaysDate = new Date();
                this.PastTwoDaysDate = new Date();
                this.FutureOneDaysDate = new Date();
                this.FutureTwoDaysDate = new Date();
                this.DisplayMatches = [];
                this._allMatches = [];
                this.GetTodayMatches();
                this.$ionicModal.fromTemplateUrl('templates/Matches/MatchPopup.html', {
                    scope: $scope,
                    animation: 'slide-in-up'
                }).then(function (modal) { $scope.MatchPopup = modal; });
                this.$ionicModal.fromTemplateUrl('templates/Accounts/TieFacebookPopup.html', {
                    scope: $scope,
                    animation: 'slide-in-up'
                }).then(function (modal) { $scope.TieFacebookPopup = modal; });
            }
            MatchController.prototype.LoginWithFacebook = function () {
                this.$scope.TieFacebookPopup.show();
            };
            MatchController.prototype.GetTodayMatches = function () {
                var _this = this;
                var user = Ionic.User.current();
                var data = new match_1.GetMatchesRequest();
                data.UserId = user.id;
                this.matchSvc.GetMatches(data)
                    .then(function (respond) {
                    _this.updateAccountInformation(respond.AccountInfo);
                    _this.updateDisplayDate(respond.CurrentDate);
                    _this.updateDisplayMatches(respond.Matches);
                    _this.updateRemainingGuessAmount();
                    _this.$ionicTabsDelegate.$getByHandle('calendarTabs').select(2);
                    console.log('Get all matches completed.');
                });
            };
            MatchController.prototype.SelectTeam = function (selectedMatch, selectedTeamId) {
                var _this = this;
                var isChangingValid = this.AccountInfo.MaximumGuessAmount > this.getSelectedTodayMatches().length;
                if (!isChangingValid) {
                    if (selectedMatch.TeamHome.IsSelected != !selectedMatch.TeamAway.IsSelected) {
                        this.$scope.MatchPopup.show();
                        return;
                    }
                }
                var isSelectedTeamHome = selectedMatch.TeamHome.Id == selectedTeamId;
                var selectedTeam = isSelectedTeamHome ? selectedMatch.TeamHome : selectedMatch.TeamAway;
                var unselectedTeam = !isSelectedTeamHome ? selectedMatch.TeamHome : selectedMatch.TeamAway;
                var beforeChange = selectedTeam.IsSelected;
                selectedTeam.IsSelected = !selectedTeam.IsSelected;
                unselectedTeam.IsSelected = false;
                var request = new match_1.GuessMatchRequest();
                request.UserId = Ionic.User.current().id;
                request.MatchId = selectedMatch.Id;
                request.IsHome = isSelectedTeamHome;
                request.IsCancel = ((selectedTeamId == selectedTeam.Id) && (beforeChange)) ? true : false;
                this.matchSvc.GuessMatch(request)
                    .then(function (respond) {
                    _this.updateAccountInformation(respond.AccountInfo);
                    _this.updateDisplayMatches(respond.Matches);
                    _this.updateRemainingGuessAmount();
                    console.log('Send guess match completed.');
                });
                this.updateRemainingGuessAmount();
            };
            MatchController.prototype.SelectDay = function (days) {
                var _this = this;
                this.DisplayMatches = this._allMatches.filter(function (it) { return _this.dateAreEqual(it.BeginDate, days); });
                console.log('# Change display matches completed.');
            };
            MatchController.prototype.IsTodayMatch = function (match) {
                return this.dateAreEqual(match.BeginDate, this.CurrentDate);
            };
            MatchController.prototype.updateAccountInformation = function (accountInfo) {
                this.AccountInfo = accountInfo;
                this.accountManagementSvc.CurrentPoints = accountInfo.Points;
                this.accountManagementSvc.CurrentOrderedCoupon = accountInfo.CurrentOrderedCoupon;
            };
            MatchController.prototype.dateAreEqual = function (firstDate, secondDate) {
                var first = new Date(firstDate.toString());
                var second = new Date(secondDate.toString());
                return first.getDay() == second.getDay();
            };
            MatchController.prototype.updateDisplayMatches = function (matches) {
                this._allMatches = matches;
                this.SelectDay(this.CurrentDate);
                console.log('# Update matches completed.');
            };
            MatchController.prototype.updateDisplayDate = function (currentDate) {
                this.CurrentDate = currentDate;
                currentDate = new Date(currentDate.toString());
                this.PastOneDaysDate.setDate(currentDate.getDate() - 1);
                this.PastTwoDaysDate.setDate(currentDate.getDate() - 2);
                this.FutureOneDaysDate.setDate(currentDate.getDate() + 1);
                this.FutureTwoDaysDate.setDate(currentDate.getDate() + 2);
                console.log('# Update date completed.');
            };
            MatchController.prototype.updateRemainingGuessAmount = function () {
                this.RemainingGuessAmount = this.AccountInfo.MaximumGuessAmount - this.getSelectedTodayMatches().length;
                console.log('# Update remaining guess amount completed.');
            };
            MatchController.prototype.getSelectedTodayMatches = function () {
                var _this = this;
                var selectedMatchesQry = this._allMatches.filter(function (it) { return (it.TeamHome.IsSelected || it.TeamAway.IsSelected) && _this.dateAreEqual(it.BeginDate, _this.CurrentDate); });
                return selectedMatchesQry;
            };
            MatchController.$inject = ['$scope', 'starter.match.MatchServices',
                '$location', '$ionicModal',
                '$ionicTabsDelegate', 'starter.shared.AccountManagementService'];
            return MatchController;
        })();
        angular
            .module('starter.match', [])
            .controller('starter.match.MatchController', MatchController);
    })(match = starter.match || (starter.match = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var match;
    (function (match) {
        var MatchInformation = (function () {
            function MatchInformation() {
            }
            return MatchInformation;
        })();
        match.MatchInformation = MatchInformation;
        var TeamInformation = (function () {
            function TeamInformation() {
            }
            return TeamInformation;
        })();
        match.TeamInformation = TeamInformation;
        var GetMatchesRequest = (function () {
            function GetMatchesRequest() {
            }
            return GetMatchesRequest;
        })();
        match.GetMatchesRequest = GetMatchesRequest;
        var GetMatchesRespond = (function () {
            function GetMatchesRespond() {
            }
            return GetMatchesRespond;
        })();
        match.GetMatchesRespond = GetMatchesRespond;
        var GuessMatchRequest = (function () {
            function GuessMatchRequest() {
            }
            return GuessMatchRequest;
        })();
        match.GuessMatchRequest = GuessMatchRequest;
        var GuessMatchRespond = (function () {
            function GuessMatchRespond() {
            }
            return GuessMatchRespond;
        })();
        match.GuessMatchRespond = GuessMatchRespond;
    })(match = starter.match || (starter.match = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var match;
    (function (match) {
        'use strict';
        var MatchServices = (function () {
            function MatchServices(queryRemoteSvc) {
                this.queryRemoteSvc = queryRemoteSvc;
            }
            MatchServices.prototype.GetMatches = function (req) {
                var requestUrl = 'Matches/GetMatches?UserId=' + req.UserId;
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            MatchServices.prototype.GuessMatch = function (req) {
                var requestUrl = 'Matches/GuessMatch?userId=' + req.UserId + '&matchId=' + req.MatchId + '&isHome=' + req.IsHome + '&isCancel=' + req.IsCancel;
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            MatchServices.$inject = ['starter.shared.QueryRemoteDataService'];
            return MatchServices;
        })();
        match.MatchServices = MatchServices;
        angular
            .module('starter.match')
            .service('starter.match.MatchServices', MatchServices);
    })(match = starter.match || (starter.match = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var reward;
    (function (reward) {
        var GetCurrentRewardsRespond = (function () {
            function GetCurrentRewardsRespond() {
            }
            return GetCurrentRewardsRespond;
        })();
        reward.GetCurrentRewardsRespond = GetCurrentRewardsRespond;
        var RewardInformation = (function () {
            function RewardInformation() {
            }
            return RewardInformation;
        })();
        reward.RewardInformation = RewardInformation;
        var GetCurrentWinnersRespond = (function () {
            function GetCurrentWinnersRespond() {
            }
            return GetCurrentWinnersRespond;
        })();
        reward.GetCurrentWinnersRespond = GetCurrentWinnersRespond;
        var WinnerAwardInformation = (function () {
            function WinnerAwardInformation() {
            }
            return WinnerAwardInformation;
        })();
        reward.WinnerAwardInformation = WinnerAwardInformation;
        var GetYourRewardsRequest = (function () {
            function GetYourRewardsRequest() {
            }
            return GetYourRewardsRequest;
        })();
        reward.GetYourRewardsRequest = GetYourRewardsRequest;
        var GetYourRewardsRespond = (function () {
            function GetYourRewardsRespond() {
            }
            return GetYourRewardsRespond;
        })();
        reward.GetYourRewardsRespond = GetYourRewardsRespond;
        var YourRewardInformation = (function () {
            function YourRewardInformation() {
            }
            return YourRewardInformation;
        })();
        reward.YourRewardInformation = YourRewardInformation;
    })(reward = starter.reward || (starter.reward = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var reward;
    (function (reward) {
        'use strict';
        var RewardController = (function () {
            function RewardController($scope, rewardSvc, accountManagementSvc) {
                this.$scope = $scope;
                this.rewardSvc = rewardSvc;
                this.accountManagementSvc = accountManagementSvc;
                this.GetRewards();
                this.GetWinners();
                this.updateDisplayRewards();
            }
            RewardController.prototype.GetRewards = function () {
                var _this = this;
                this.rewardSvc.GetCurrentRewards()
                    .then(function (respond) {
                    _this.RewardInfo = respond;
                    _this.accountManagementSvc.CurrentTicketCost = respond.TicketCost;
                    console.log('Get all rewards completed.');
                });
            };
            RewardController.prototype.GetWinners = function () {
                var _this = this;
                this.rewardSvc.GetCurrentWinners()
                    .then(function (respond) {
                    _this.WinnersInfo = respond;
                    console.log('Get all winners completed.');
                });
            };
            RewardController.prototype.updateDisplayRewards = function () {
                var _this = this;
                var user = Ionic.User.current();
                var getYourRewardsRequest = new reward.GetYourRewardsRequest();
                getYourRewardsRequest.UserId = user.id;
                this.rewardSvc.GetYourRewards(getYourRewardsRequest)
                    .then(function (respond) {
                    _this.ContactNo = respond.ContactNo;
                    _this.CurrentRewards = respond.CurrentRewards;
                    _this.AllRewards = respond.AllRewards;
                    console.log('# update display rewards completed.');
                });
            };
            RewardController.$inject = ['$scope', 'starter.reward.RewardServices', 'starter.shared.AccountManagementService'];
            return RewardController;
        })();
        angular
            .module('starter.reward', [])
            .controller('starter.reward.RewardController', RewardController);
    })(reward = starter.reward || (starter.reward = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var reward;
    (function (reward) {
        'use strict';
        var RewardServices = (function () {
            function RewardServices(queryRemoteSvc) {
                this.queryRemoteSvc = queryRemoteSvc;
            }
            RewardServices.prototype.GetCurrentRewards = function () {
                var requestUrl = 'Reward/GetCurrentRewards';
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            RewardServices.prototype.GetCurrentWinners = function () {
                var requestUrl = 'Reward/GetCurrentWinners';
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            RewardServices.prototype.GetYourRewards = function (req) {
                var requestUrl = 'Reward/GetYourRewards?userId=' + req.UserId;
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            RewardServices.$inject = ['starter.shared.QueryRemoteDataService'];
            return RewardServices;
        })();
        reward.RewardServices = RewardServices;
        angular
            .module('starter.reward')
            .service('starter.reward.RewardServices', RewardServices);
    })(reward = starter.reward || (starter.reward = {}));
})(starter || (starter = {}));
(function () {
    'use strict';
    angular
        .module('starter.shared', []);
})();
var starter;
(function (starter) {
    var shared;
    (function (shared) {
        'use strict';
        var AccountManagementService = (function () {
            function AccountManagementService($location, accountSvc, Azureservice) {
                this.$location = $location;
                this.accountSvc = accountSvc;
                this.Azureservice = Azureservice;
            }
            AccountManagementService.prototype.GetAccountInformation = function () {
                var user = Ionic.User.current();
                var accountInfo = new starter.account.AccountInformation();
                //accountInfo.CurrentOrderedCoupon
                //accountInfo.Email
                //accountInfo.MaximumGuessAmount
                accountInfo.OAuthId = user.get('OAuthId');
                accountInfo.Points = this.CurrentPoints;
                accountInfo.SecretCode = user.id;
                accountInfo.VerifiedPhoneNumber = user.get('PhoneVerified');
                return accountInfo;
            };
            //For test only (remove when run on production)
            AccountManagementService.prototype.ClearGuestData = function () {
                var user = Ionic.User.current();
                user.id = 'empty';
                user.unset('points');
                user.unset('IsSkiped');
                user.unset('PhoneVerified');
                user.unset('OAuthId');
                user.save();
            };
            //Set phone be verified
            AccountManagementService.prototype.SetPhoneVerified = function () {
                var user = Ionic.User.current();
                user.set('PhoneVerified', 'true');
                user.save();
            };
            //// Login Facebook ////
            AccountManagementService.prototype.LoginWithFacebook = function () {
                var _this = this;
                this.Azureservice.login('facebook')
                    .then(function () {
                    var oAuthId = _this.Azureservice.getCurrentUser().userId;
                    _this.accountSvc.GetAccountByOAuthId(oAuthId)
                        .then(function (respond) {
                        if (respond == null) {
                            var user = Ionic.User.current();
                            if (!user.id || user.id == 'empty') {
                                // ทำการ login ด้วย facebook ที่ยังไม่เคยใช้งานระบบมาก่อน
                                _this.CreateNewGuestWithFacebook(oAuthId);
                            }
                        }
                        else {
                            // ทำการ login ด้วย facebook ที่เคยใช้งานระบบแล้ว
                            _this.UpdateLocalStorageAccountWithFacebookData(respond);
                            _this.$location.path('/matches/todaymatches');
                        }
                    }).catch(function () {
                        alert('cannot connect to server');
                    });
                    console.log('Login successful');
                }, function (err) {
                    console.error('Azure Error: ' + err);
                });
            };
            //สร้าง guestuser ใหม่
            AccountManagementService.prototype.CreateNewGuestUser = function () {
                var _this = this;
                var user = Ionic.User.current();
                this.accountSvc.CreateNewGuest()
                    .then(function (respond) {
                    user.id = respond.AccountInfo.SecretCode;
                    user.set('IsSkiped', 'true');
                    user.set('PhoneVerified', 'false');
                    user.save();
                    console.log('Create new guest complete. #UserId: ' + user.id);
                    _this.$location.path('/account/favorite');
                });
            };
            //สร้างguestuserใหม่ และเชื่อมต่อfacebook 
            AccountManagementService.prototype.CreateNewGuestWithFacebook = function (oAuthId) {
                var _this = this;
                this.accountSvc.CreateNewGuestWithFacebook(oAuthId)
                    .then(function (respond) {
                    var user = Ionic.User.current();
                    user.id = respond.AccountInfo.SecretCode;
                    user.set('IsSkiped', 'true');
                    user.set('PhoneVerified', 'false');
                    user.set('OAuthId', respond.AccountInfo.OAuthId);
                    user.save();
                    console.log('Login with Facebook complete. #UserId: ' + user.id);
                    _this.$location.path('/account/favorite');
                });
            };
            // ดึงข้อมูลจาก facebook มาเก็บไว้ที่ storage account
            AccountManagementService.prototype.UpdateLocalStorageAccountWithFacebookData = function (accountInfo) {
                var user = Ionic.User.current();
                user.id = accountInfo.SecretCode;
                var PhoneVerified = accountInfo.VerifiedPhoneNumber != null;
                user.set('OAuthId', accountInfo.OAuthId);
                user.set('IsSkiped', 'true');
                user.set('PhoneVerified', PhoneVerified);
                user.save();
            };
            //// Tie Facebook ////
            AccountManagementService.prototype.TieFacebook = function () {
                var _this = this;
                this.Azureservice.login('facebook')
                    .then(function () {
                    var oAuthId = _this.Azureservice.getCurrentUser().userId;
                    _this.accountSvc.GetAccountByOAuthId(oAuthId)
                        .then(function (respond) {
                        var user = Ionic.User.current();
                        if (respond == null) {
                            // TODO : tie facebook ที่ยังไม่เคยใช้งานระบบมาก่อน
                            _this.TieAccoutWithNewFacebook(user.id, oAuthId);
                        }
                        else {
                            // facebook ที่เคยใช้งานระบบแล้ว ให้ผู้ใช้เลือกข้อมูล
                            _this.facebookPoint = respond.Points;
                            _this.OAuthId = oAuthId;
                            _this.accountSvc.GetAccountBySecretCode(user.id)
                                .then(function (respond) {
                                _this.localPoint = respond.Points;
                                _this.$location.path('/account/tiefacebook');
                            });
                        }
                    });
                }, function (err) {
                    console.error('Azure Error: ' + err);
                });
            };
            AccountManagementService.prototype.TieFacbookWithFacebookData = function () {
                var _this = this;
                var user = Ionic.User.current();
                this.accountSvc.TieFacbookWithFacebookData(user.id, this.OAuthId)
                    .then(function (respond) {
                    _this.accountSvc.GetAccountByOAuthId(_this.OAuthId)
                        .then(function (accountInfo) {
                        var PhoneVerified = accountInfo.VerifiedPhoneNumber != null;
                        user.set('OAuthId', _this.OAuthId);
                        user.set('PhoneVerified', PhoneVerified);
                        user.save();
                        _this.$location.path('/matches/todaymatches');
                    });
                });
            };
            AccountManagementService.prototype.TieFacbookWithLocalData = function () {
                var _this = this;
                var user = Ionic.User.current();
                this.accountSvc.TieFacbookWithLocalData(user.id, this.OAuthId)
                    .then(function (respond) {
                    _this.accountSvc.GetAccountByOAuthId(_this.OAuthId)
                        .then(function (accountInfo) {
                        var PhoneVerified = accountInfo.VerifiedPhoneNumber != null;
                        user.set('OAuthId', _this.OAuthId);
                        user.set('PhoneVerified', PhoneVerified);
                        user.save();
                        _this.$location.path('/matches/todaymatches');
                    });
                });
            };
            //ผูก facebook เข้ากับ guest user เดิม
            AccountManagementService.prototype.TieAccoutWithNewFacebook = function (secretCode, oAuthId) {
                var _this = this;
                this.accountSvc.UpdateAccountWithFacebook(secretCode, oAuthId)
                    .then(function (respond) {
                    if (respond) {
                        var user = Ionic.User.current();
                        user.set('OAuthId', oAuthId);
                        user.save();
                        _this.$location.path('/ticket/buyticket');
                    }
                });
            };
            AccountManagementService.$inject = ['$location', 'starter.account.AccountServices', 'Azureservice'];
            return AccountManagementService;
        })();
        shared.AccountManagementService = AccountManagementService;
        angular
            .module('starter.shared')
            .service('starter.shared.AccountManagementService', AccountManagementService);
    })(shared = starter.shared || (starter.shared = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var shared;
    (function (shared) {
        'use strict';
        var QueryRemoteDataService = (function () {
            function QueryRemoteDataService($http) {
                this.$http = $http;
                this.serviceURL = 'http://localhost:3728/api/';
            }
            QueryRemoteDataService.prototype.RemoteQuery = function (baseUrl) {
                return this.$http({ method: 'GET', url: this.serviceURL + baseUrl })
                    .then(function (respond) { return respond.data; });
            };
            QueryRemoteDataService.$inject = ['$http'];
            return QueryRemoteDataService;
        })();
        shared.QueryRemoteDataService = QueryRemoteDataService;
        angular
            .module('starter.shared')
            .service('starter.shared.QueryRemoteDataService', QueryRemoteDataService);
    })(shared = starter.shared || (starter.shared = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var sidemenu;
    (function (sidemenu) {
        'use strict';
        var SideMenuController = (function () {
            function SideMenuController($scope, $timeout, $location, $ionicModal, Azureservice, AccountManagementService) {
                this.$scope = $scope;
                this.$timeout = $timeout;
                this.$location = $location;
                this.$ionicModal = $ionicModal;
                this.Azureservice = Azureservice;
                this.AccountManagementService = AccountManagementService;
                this.checkCurrenUserLogin();
                this.$ionicModal.fromTemplateUrl('templates/Accounts/TieFacebookPopup.html', {
                    scope: $scope,
                    animation: 'slide-in-up'
                }).then(function (modal) { $scope.TieFacebookPopup = modal; });
            }
            SideMenuController.prototype.LoginWithFacebookPopup = function () {
                this.$scope.TieFacebookPopup.show();
            };
            SideMenuController.prototype.LoginWithFacebook = function () {
                this.$scope.TieFacebookPopup.hide();
                this.AccountManagementService.TieFacebook();
            };
            SideMenuController.prototype.Logout = function () {
                var user = Ionic.User.current();
                user.id = 'empty';
                user.save();
                this.$location.path('/account/login');
            };
            SideMenuController.prototype.checkCurrenUserLogin = function () {
                var user = Ionic.User.current();
                var OAuthId = user.get('OAuthId');
                if (OAuthId) {
                    this.isLogedin = true;
                }
                else {
                    this.isLogedin = false;
                }
            };
            SideMenuController.$inject = ['$scope', '$timeout', '$location', '$ionicModal', 'Azureservice', 'starter.shared.AccountManagementService'];
            return SideMenuController;
        })();
        angular
            .module('starter.sidemenu', [])
            .controller('starter.sidemenu.SideMenuController', SideMenuController);
    })(sidemenu = starter.sidemenu || (starter.sidemenu = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var sidemenu;
    (function (sidemenu) {
        var AccountInformation = (function () {
            function AccountInformation() {
            }
            return AccountInformation;
        })();
        sidemenu.AccountInformation = AccountInformation;
    })(sidemenu = starter.sidemenu || (starter.sidemenu = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var ticket;
    (function (ticket) {
        'use strict';
        var TicketController = (function () {
            function TicketController($scope, $stateParams, $timeout, $location, $ionicModal, ticketSvc, accountSvc) {
                this.$scope = $scope;
                this.$stateParams = $stateParams;
                this.$timeout = $timeout;
                this.$location = $location;
                this.$ionicModal = $ionicModal;
                this.ticketSvc = ticketSvc;
                this.accountSvc = accountSvc;
                this.RemainingPoints = this.$stateParams.remainingPoints;
                this.ExpiredDate = this.$stateParams.expiredDate;
                this.$ionicModal.fromTemplateUrl('templates/Rewards/BuyTicketPopup.html', {
                    scope: $scope,
                    animation: 'slide-in-up'
                }).then(function (modal) { $scope.ErrorPopup = modal; });
                this.$ionicModal.fromTemplateUrl('templates/Accounts/TieFacebookPopup.html', {
                    scope: $scope,
                    animation: 'slide-in-up'
                }).then(function (modal) { $scope.TieFacebookPopup = modal; });
            }
            TicketController.prototype.LoginWithFacebook = function () {
                this.$scope.TieFacebookPopup.hide();
                this.accountSvc.TieFacebook();
            };
            TicketController.prototype.BuyTicket = function (amount) {
                var _this = this;
                var accountInformation = this.accountSvc.GetAccountInformation();
                var MinimumAmount = 1;
                var canBuyTicket = (amount >= MinimumAmount) && (accountInformation.Points >= amount * this.accountSvc.CurrentTicketCost);
                if (!canBuyTicket) {
                    this.$scope.ErrorPopup.show();
                    return;
                }
                var isTieWithFacaebookAlready = (accountInformation.OAuthId != null) && (accountInformation.SecretCode != null);
                if (!isTieWithFacaebookAlready) {
                    this.$scope.TieFacebookPopup.show();
                    return;
                }
                var isVerifiedPhoneNumber = (accountInformation.VerifiedPhoneNumber == 'true');
                if (!isVerifiedPhoneNumber) {
                    this.$location.path('/verify/verifyphonenumber/' + amount);
                    return;
                }
                console.log('#Begin send buy ticket request.');
                var user = Ionic.User.current();
                var request = new ticket.BuyTicketRequest();
                request.UserId = user.id;
                request.Amount = amount;
                this.ticketSvc.BuyTicket(request)
                    .then(function (respond) {
                    if (respond.IsSuccessed) {
                        _this.AccountInfo = respond.AccountInfo;
                        _this.DisplayRewardResultDate = new Date(respond.RewardResultDate.toString());
                        console.log('Buy ticket completed.');
                        _this.$location.path('/buyticketcompleted/buyticketcompleted/' + respond.AccountInfo.Points + '/' + respond.RewardResultDate);
                    }
                    else {
                        // TODO: Buy ticket failed
                        console.log('Buy ticket failed.');
                    }
                });
            };
            TicketController.$inject = ['$scope', '$stateParams', '$timeout', '$location', '$ionicModal', 'starter.ticket.TicketServices', 'starter.shared.AccountManagementService'];
            return TicketController;
        })();
        angular
            .module('starter.ticket', [])
            .controller('starter.ticket.TicketController', TicketController);
    })(ticket = starter.ticket || (starter.ticket = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var ticket;
    (function (ticket) {
        var BuyTicketRespond = (function () {
            function BuyTicketRespond() {
            }
            return BuyTicketRespond;
        })();
        ticket.BuyTicketRespond = BuyTicketRespond;
        var BuyTicketRequest = (function () {
            function BuyTicketRequest() {
            }
            return BuyTicketRequest;
        })();
        ticket.BuyTicketRequest = BuyTicketRequest;
    })(ticket = starter.ticket || (starter.ticket = {}));
})(starter || (starter = {}));
var starter;
(function (starter) {
    var ticket;
    (function (ticket) {
        'use strict';
        var TicketServices = (function () {
            function TicketServices(queryRemoteSvc) {
                this.queryRemoteSvc = queryRemoteSvc;
            }
            TicketServices.prototype.BuyTicket = function (req) {
                var requestUrl = "BuyTicket/BuyTicket?userId=" + req.UserId + "&amount=" + req.Amount;
                return this.queryRemoteSvc.RemoteQuery(requestUrl);
            };
            ;
            TicketServices.$inject = ['starter.shared.QueryRemoteDataService'];
            return TicketServices;
        })();
        ticket.TicketServices = TicketServices;
        angular
            .module('starter.ticket')
            .service('starter.ticket.TicketServices', TicketServices);
    })(ticket = starter.ticket || (starter.ticket = {}));
})(starter || (starter = {}));
//# sourceMappingURL=appBundle.js.map