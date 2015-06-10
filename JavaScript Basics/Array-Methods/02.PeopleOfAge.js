/**Write a function that checks if an array of person contains only people of age (with age 18 or greater)
 Use only array methods and no regular loops (for, while)*/
console.log('TASK 2');

function creatingPersons(fName, lName, age, gender) {
    return {
        firstName: fName,
        lastName: lName,
        age: age,
        gender: gender,
        print: function () {
            return this.firstName + ' ' + this.lastName + ' age: ' + this.age + ' ' + this.gender
        }
    }
}

var misho = creatingPersons('Mihail', 'Jelqzkov', 47, false),
    hristo = creatingPersons('Hristo, Stefanov', 54, false),
    ivailo = creatingPersons('Ivailo', 'Tynev', 27, false),
    veronika = creatingPersons('Veronika', 'Gencheva', 35, true),
    radka = creatingPersons('Radka', 'Yovkova', 18, true),
    zlatina = creatingPersons('Zlatina', 'Ivanova', 42, true),
    nikol = creatingPersons('Nikol', 'Petrova', 7, true),
    bojidar = creatingPersons('Bojidar', 'Muhov', 12, false),
    stoqn = creatingPersons('Stoqn', 'Gaidarski', 25, false),
    mariq = creatingPersons('Mariq', 'Ignatova', 33, true);

var persons = [misho, hristo, ivailo, veronika, radka, zlatina, nikol, bojidar, stoqn, mariq];

function onlyPeopleAbove18(item) {
    return item.age >= 18;
}


console.log(persons.every(onlyPeopleAbove18));