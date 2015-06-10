/* 04. Sort 3 real values in descending order.
 Use nested if statements.*/
console.log('TASK 4')
var a = 10;
var b = 20;
var c = 30;

if (a > b) {
    if (a > c) {
        if (c > b) {
            console.log(a + ' ' + c + ' ' + b);
        }
        else {
            console.log(a + ' ' + b + ' ' + c);
        }
    }
    else {
        console.log(c + ' ' + a + ' ' + b);
    }
}
else {
    if (b > c) {
        if (c > a) {
            console.log(b + ' ' + c + ' ' + a);
        }
        else {
            console.log(b + ' ' + a + ' ' + c);
        }
    }
    else {
        console.log(c + ' ' + b + ' ' + a);
    }
}