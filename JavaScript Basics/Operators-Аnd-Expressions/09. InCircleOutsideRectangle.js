// 09. Write an expression that checks for given point P(x, y)
// if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
console.log('Task9');

var x = 2.5;
var y = 1.5;
var circleX = 1;
var circleY = 1;
var radius = 3;

var isInsideCircle = (x - circleX)*(x - circleX) + (y - circleY)*(y - circleY) < radius*radius;
var isOutsideRectangle = (x < -1 && x > 5) && (y > -1 && y < 1);

var isTrue = isInsideCircle && isOutsideRectangle ? 'Yes' : 'No';
console.log('Is it the point in the circle and outside the rectangle: ' + isTrue);