/**Write a function that groups an array of people by age, first or last name.
 The function must return an associative array, with keys - the groups, and values - arrays with people in this groups*/
console.log('TASK 6');

function buildPerson(fname, lname, age) {
    return {
        firstName: fname,
        lastName: lname,
        age: age
    }
}
var misho = buildPerson('Mihail', 'Jelqzkov', 47),
    hristo = buildPerson('Hristo, Stefanov', 54),
    ivailo = buildPerson('Ivailo', 'Tynev', 27),
    veronika = buildPerson('Veronika', 'Gencheva', 35),
    radka = buildPerson('Radka', 'Yovkova', 18),
    zlatina = buildPerson('Zlatina', 'Ivanova', 42),
    nikol = buildPerson('Nikol', 'Petrova', 7);

var array = [misho, hristo, ivailo, veronika, radka, zlatina, nikol];

function group(array, criterii) {
    var hashMap = {};
    for (var person in array) {
        if (!array.hasOwnProperty(person)) {
            continue;
        }
        else {
            if (!hashMap[array[person][criterii]]) {
                hashMap[array[person][criterii]] = [];
                hashMap[array[person][criterii]].push(array[person].firstName + ' ' + array[person].lastName);
            }
            else {
                hashMap[array[person][criterii]].push(array[person].firstName + ' ' + array[person].lastName);
            }
        }
    }
    return hashMap;
}

var criterii='age';
var result = group(array, criterii);
console.log('Sorted by age:');
for (var key in result) {
    console.log(key + ' : ' + result[key]);
}
