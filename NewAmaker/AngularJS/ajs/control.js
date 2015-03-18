function namesController($scope) {   
    $scope.person = {
        firstName: "13adsdas"
    }
    $scope.names = [
       { name: $scope.person.firstName, country: 'Norway' },
       { name: 'Hege', country: 'Sweden' },
       { name: 'Kai', country: 'Denmark' }
    ];
}