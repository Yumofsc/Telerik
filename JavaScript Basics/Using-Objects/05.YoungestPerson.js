/**Write a function that finds the youngest person in a given array of people and prints his/hers full name
 Each person has properties firstName, lastName and age.*/
console.log('TASK 5');

var person = function (fName, lName, age) {
    return {
        firstName: fName,
        lastName: lName,
        age: age,
        toString: function () {
            return this.firstName + ' ' + this.lastName + ' - age: ' + this.age;
        }

    }
};

var peter = person('Peter', 'Ivanov', 27),
    stamat = person('Stamat', 'Matev', 20),
    mariika = person('Mariika', 'Stefanova', 10),
    john = person('John', 'Whilliams', 18);

    personArray = [peter, stamat, mariika, john];

function findYoungestPerson(array) {
    var minAge = array[0].age;
    var youngPerson = array[0];
    for (var i in array) {
        if (array[i].age < minAge) {
            minAge = array[i].age;
            youngestPerson = array[i];
        }
    }
    return youngestPerson
}
var youngest = findYoungestPerson(personArray);
console.log(youngest.toString());