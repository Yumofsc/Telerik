/**Write a function that prints all under aged persons of an array of person
 Use Array#filter and Array#forEach
 Use only array methods and no regular loops (for, while)*/
console.log('TASK 3');

function creatingPersons(fName, lName, age, gender) {
    return {
        firstName: fName,
        lastName: lName,
        age: age,
        gender: gender,
        print: function () {
            return this.firstName + ' ' + this.lastName + ' age: ' + this.age
        }
    }
}
var misho = creatingPersons('Mihail', 'Jelqzkov', 47, false),
    hristo = creatingPersons('Hristo', 'Stefanov', 4, false),
    ivailo = creatingPersons('Ivailo', 'Tynev', 27, false),
    veronika = creatingPersons('Veronika', 'Gencheva', 35, true),
    radka = creatingPersons('Radka', 'Yovkova', 18, true),
    zlatina = creatingPersons('Zlatina', 'Ivanova', 42, true),
    nikol = creatingPersons('Nikol', 'Petrova', 7, true),
    bojidar = creatingPersons('Bojidar', 'Muhov', 12, false),
    stoqn = creatingPersons('Stoqn', 'Gaidarski', 25, false),
    mariq = creatingPersons('Mariq', 'Ignatova', 33, true);

var persons = [misho, hristo, ivailo, veronika, radka, zlatina, nikol, bojidar, stoqn, mariq];




var young =  persons.filter(function(item) {
    return item.age < 18;
})
    young.forEach(function(item) {
    console.log(item.print());
});

