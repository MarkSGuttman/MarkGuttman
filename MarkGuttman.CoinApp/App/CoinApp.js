(function () {
    //angular.module('coinApp', ['ngMaterial', 'nvd3']).controller('ToolbarCtrl', function ($scope) {
    //    $scope.title = "Mark Guttman"
    //});

    var webapiApp = angular.module('webapi', ['ngResource']);
    
    webapiApp.factory('WebApiFactory', ['$resource', WebApiFactory]);

    function WebApiFactory($resource) {
        return function (url, paramDefaults, actions) {
            var apiParamDefaults = {};
            if (paramDefaults) for (var i in paramDefaults) apiParamDefaults[i] = paramDefaults[i];
            var apiActions = {
                'query': { method: 'GET', isArray: true },
                'get': { method: 'GET', isArray: true },
                'post': { method: 'POST' },
                'remove': { method: 'DELETE', url: url + '(:id)' },
                'patch': { method: 'PATCH', url: url + '(:id)' }
            }

            if (actions) for (var i in actions) apiActions[i] = actions[i];
            var webapi = $resource(url, apiParamDefaults, apiActions);
            return webapi;
        }
    }

    var app = angular.module('coinApp', ['ngMaterial', 'ngResource', 'nvd3', 'webapi']);

    app.controller('TitleController', TitleController);

    app.controller('FooterController', FooterController)

    app.controller('AppCtrl', AppCtrl).factory('ChangeFactory', ['WebApiFactory', ChangeFactory]).directive('resize', reSize).directive('bar', bar);

    var Coin = function (coin) {
        if (!coin) { coin = {}; }

        var coin = {
            key: coin.key | "",
            y: coin.y | 0
        };

        return coin;
    }

    function TitleController($scope) {
        $scope.title = 'Mark Guttman';
    }

    function ChangeFactory(WebApiFactory) {
        var getChange = function () {
            var data = [{
                key: "Silver Dollar",
                y: 5
            }, {
                key: "Half Dollar",
                y: 2
            }, {
                key: "Quarter",
                y: 9
            }, {
                key: "Dime",
                y: 7
            }, {
                key: "Nickel",
                y: 4
            }, {
                key: "Penny",
                y: 3
            }
            ];

            return transformResponse(data); // data;
        };

        function transformResponse(data) {
            var template = [{ key: "Coins", values: [] }];
            for (i = 0; i < data.length; i++) {
                template[0].values.push({
                    "label": data[i].key,
                    "value": data[i].y
                });
            }

            return { pie: data, bar: template };
        };

        var changeService = { getChange: getChange };
        return changeService;
    }

    function AppCtrl($scope, ChangeFactory, $timeout) {
        $scope.dataTwo = [];

        $scope.data = [{
            key: "Silver Dollar",
            y: 0
        }, {
            key: "Half Dollar",
            y: 0
        }, {
            key: "Quarter",
            y: 0
        }, {
            key: "Dime",
            y: 0
        }, {
            key: "Nickel",
            y: 0
        }, {
            key: "Penny",
            y: 0
        }
        ];;
        function init() {
            $scope.data = ChangeFactory.getChange().pie;
            $scope.dataTwo = ChangeFactory.getChange().bar;
        }

        $timeout(init(), 30000);
    }

    function FooterController($scope) {
        $scope.changeAmmount = 0.0;
    }

    function reSize($window, $timeout) {
        var linker = function (scope, element, attrs) {
            var w = angular.element($window);

            $timeout(function () {
                updateHeight();
                updateWidth();
                scope.api.updateWithOptions(scope.options);
            }, 40);

            scope.options = {
                chart: {
                    type: 'pieChart',
                    height: '100%',
                    width: element.parent()[0].clientWidth,
                    donut: true,
                    x: function (d) { return d.key; },
                    y: function (d) { return d.y; },
                    showLabels: true,
                    pie: {
                        startAngle: function (d) { return d.startAngle / 2 - Math.PI / 2 },
                        endAngle: function (d) { return d.endAngle / 2 - Math.PI / 2 }
                    },
                    duration: 500,
                    legend: {
                        margin: {
                            top: 5,
                            right: 140,
                            bottom: 5,
                            left: 0
                        }
                    }
                }
            };

            w.bind('resize', function () {
                updateHeight();
                updateWidth();
                scope.api.updateWithOptions(scope.options);
            });

            function updateHeight() {
                scope.options.chart.height = element.parent()[0].clientHeight;
            }

            function updateWidth() {
                scope.options.chart.width = element.parent()[0].clientWidth;
            }
        }

        return {
            template: '<nvd3 options="options" data="data" api="api"></nvd3>',
            restrict: "E",
            link: linker,
            scope: {
                data: '=',
            }
        };
    }

    function bar($window, $timeout) {
        var linker = function (scope, element, attrs) {
            var w = angular.element($window);

            $timeout(function () {
                updateHeight();
                updateWidth();
                scope.api.updateWithOptions(scope.options);
            }, 30);

            scope.options = {
                chart: {
                    type: 'discreteBarChart',
                    height: element.parent()[0].clientHeight,
                    width: element.parent()[0].clientWidth,
                    margin: {
                        top: 20,
                        right: 20,
                        bottom: 50,
                        left: 55
                    },
                    x: function (d) {
                        return d.label;
                    },
                    y: function (d) {
                        return d.value + (1e-10);
                    },
                    showValues: true,
                    valueFormat: function (d) {
                        return d3.format(',.4f')(d);
                    },
                    duration: 500,
                    xAxis: {
                        axisLabel: 'X Axis'
                    },
                    yAxis: {
                        axisLabel: 'Y Axis',
                        axisLabelDistance: -10
                    }
                }
            };

            w.bind('resize', function () {
                updateHeight();
                updateWidth();
                scope.api.updateWithOptions(scope.options);
            });

            function updateHeight() {
                scope.options.chart.height = element.parent()[0].clientHeight;
            }

            function updateWidth() {
                scope.options.chart.width = element.parent()[0].clientWidth;
            }
        }

        return {
            template: '<nvd3 options="options" data="data" api="api"></nvd3>',
            restrict: "E",
            link: linker,
            scope: {
                data: '=',
            }
        };
    }
})();

