//02. Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
console.log('TASK 2');

var a = -2;
var b = -2;
var c = 1;
var result = a * b * c;

if (result > 0){
    console.log('+');
}else if (result === 0) {
    console.log('0');
}else {
    console.log('-');
}
