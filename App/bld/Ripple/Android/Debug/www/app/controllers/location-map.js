(function() {
    'use strict'

    angular.module('eliteApp').controller('LocationMapCtrl', ['$stateParams', LocationMapCtrl])

    function LocationMapCtrl() {
        var vm = this;
        vm.locationId = Number($stateParams.id);
        vm.map = {
            center: {
                latitude: 30.897677,
                longitude: -77.036530,
            },
            zoom: 12
        };
        vm.Marker = {}
    };
})();