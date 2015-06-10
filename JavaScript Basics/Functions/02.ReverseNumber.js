/**Write a function that reverses the digits of given decimal number.
 Example:
 input	 | output
 256	 | 652
 123.45	 | 54.321*/
console.log('TASK 2');

var number = 123.45;

function reverseNumber(number){
    var strNumber = number.toString();
    var newNumber = '';

    for (var i = strNumber.length - 1; i >= 0; i--) {
        newNumber += strNumber[i];
    }
    return newNumber * 1;
}
console.log(reverseNumber(number));