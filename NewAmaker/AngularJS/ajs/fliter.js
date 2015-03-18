function personController($scope) {

    $scope.person = {
        quantity: 1,
        price: 12,
        lastName: "ADWDAadasda`WD"
    }
    $scope.fullName = function () {
        var x;
        x = $scope.person;
        return x.quantity * x.price;
    };
}