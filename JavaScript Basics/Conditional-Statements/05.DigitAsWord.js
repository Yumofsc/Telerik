/*05. Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
 Print �not a digit� in case of invalid input.
 Use a switch statement.*/
console.log('TASK 5');

var number =  6;
console.log('digit: ' + number);

switch (number) {
    case 1: console.log('one'); break;
    case 2: console.log('two'); break;
    case 3: console.log('three'); break;
    case 4: console.log('four'); break;
    case 5: console.log('five'); break;
    case 6: console.log('six'); break;
    case 7: console.log('seven'); break;
    case 8: console.log('eight'); break;
    case 9: console.log('nine'); break;
    case 0: console.log('zero'); break;
    default: console.log('not a digit')
}