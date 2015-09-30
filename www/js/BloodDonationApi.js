(function () {
    'use strict';

    angular.module('BloodDonationApp').factory('BloodDonationApi', [BloodDonationApi]);

    function BloodDonationApi() {

        var requests = JSON.parse('[{"id":1,"unitNb":5,"Hosplocation":"beirut","HospName":"Shkieh rageb hareb","type":"A+"},{"id":2,"unitNb":8,"Hosplocation":"beirut","HospName":"Shkieh rageb hareb","type":"O+"},{"id":3,"unitNb":3,"Hosplocation":"beirut","HospName":"Shkieh rageb hareb","type":"B+"},{"id":4,"unitNb":6,"Hosplocation":"beirut","HospName":"Shkieh rageb hareb","type":"AB+"},{"id":5,"unitNb":2,"Hosplocation":"beirut","HospName":"Shkieh rageb hareb","type":"AB-"}]');

        

        function getRequests() {
            return requests;
        }
        return {
            getRequests: getRequests
        };
    };

})();