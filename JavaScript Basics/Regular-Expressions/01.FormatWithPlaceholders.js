/**Write a function that formats a string. The function should have placeholders, as shown in the example
 Add the function to the String.prototype*/
console.log('TASK 1');

var text = 'My name is #{name}. I have #{color} eyes and I am #{age}-years-old';

String.prototype.format = function(options) {
    var option,
        result = this;
    for (option in options) {
        result = result.replace(new RegExp('#{' + option + '}', 'g'), options[option]);
    }
    return result;
};
var person = {
    name: 'John',
    age: 26,
    color: 'blue'

};

var print = text.format(person);
console.log(print);