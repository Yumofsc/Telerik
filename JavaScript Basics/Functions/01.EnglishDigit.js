/**Write a function that returns the last digit of given integer as an English word.
 *
 * Examples:
 input	| output
 512	| two
 1024	| four
 12309	| nine*/
console.log('TASK 1');

var number = 12309;

function lastDigitAsWord(number){
   var lastDigit = number % 10;

    switch(lastDigit) {
        case 0: return 'zero';
        case 1: return 'one';
        case 2: return 'two';
        case 3: return 'tree';
        case 4: return 'four';
        case 5: return 'five';
        case 6: return 'six';
        case 7: return 'seven';
        case 8: return 'eight';
        case 9: return 'nine';
        default : 'This is not a number';
    }

}
console.log(lastDigitAsWord(number));
