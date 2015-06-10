/**Write a function that checks if a given object contains a given property.*/
console.log('TASK 4');

var person = {
    name: 'Stamat',
    age: '27'
};
var property = 'name';
var secondProperty = 'sex'; //use it to try when not contains a given property

function objectHasProperty(object, property){
    for (var i in object) {
        if (i === property) {
          return true;
         }
    }
    return false;
}
console.log(objectHasProperty(person, property));