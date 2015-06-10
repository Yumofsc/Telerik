// 04. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 ? true.
console.log('Task4');

var number = 1832;
var thirdDigit = Math.floor(number / 100) % 10;

var checkDigit = thirdDigit  === 7;

console.log('The number is: ' + number);
console.log('Is it third digit 7? ' + checkDigit);
