/*07. Write a script that finds the greatest of given 5 variables.
 Use nested if statements.*/
console.log('TASK 7');

var a = 2,
    b = 3,
    c = 6,
    d = 6,
    e = 1;

if (a >= b && a >= c && a >= d && a >= e) {
    console.log(a);
}
else if (b >= a && b >= c && b >= d && b >= e) {
    console.log(b);
}
else if (c >= a && c >= b && c >= d && c >= e) {
    console.log(c)
}
else if (d >= a && d >= b && d >= c && d >= e) {
    console.log(d);
}
else if (e >= a && e >= b && e >= c && e >= d) {
    console.log(e);
}
