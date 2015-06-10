/**Write a function that calculates the average age of all females, extracted from an array of persons
 Use Array#filter
 Use only array methods and no regular loops (for, while)*/
console.log('TASK 4');
//Da dovursha!!!
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
    viktoria = creatingPersons('Viktoria', 'Nikolova', 12, true),
    stoqn = creatingPersons('Stoqn', 'Gaidarski', 25, false),
    mariq = creatingPersons('Mariq', 'Ignatova', 33, true);

var persons = [misho, hristo, ivailo, veronika, radka, zlatina, nikol, viktoria, stoqn, mariq];



var female = persons.filter(function(item){
    return item.gender == true;
});
function average(s, item){
    return (s + item.age)
}
var sum = female.reduce(average, 0);
console.log(sum);

