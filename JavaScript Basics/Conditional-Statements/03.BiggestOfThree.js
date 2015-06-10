/*03 Write a script that finds the biggest of three numbers.
 Use nested if statements.*/
console.log('TASK 3');

var a = 5;
var b = 7;
var c = 22;

if (a > b) {
    if (a > c) {
        console.log(a);
    }else {
        console.log(c);
    }
}else {
    if (b > c) {
        console.log(b);
    }else {
        console.log(c);
    }
}