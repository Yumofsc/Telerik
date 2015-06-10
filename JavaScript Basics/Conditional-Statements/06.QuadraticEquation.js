/*07. Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 Calculates and prints its real roots.
 Note: Quadratic equations may have 0, 1 or 2 real roots.*/
console.log('TASK 6');

// ax^2 + bx + c = 0
// D = b^2 - 4ac
var a = 2,
    b = 5,
    c = -3,
    x1,
    x2;

var discriminant = b * b - 4 * a * c;

if (discriminant < 0) {
    console.log('No real roots')
}
else if (discriminant === 0) {
    x1 = x2 = -b / (2 * a);
    console.log('One root: x = ' + x1);
}
else {
    x1 = (-b - Math.sqrt(discriminant)) / (2 * a);
    x2 = (-b + Math.sqrt(discriminant)) / (2 * a);
    console.log('x1 = ' + x1 + ' ' + 'x2 = ' + x2);
}