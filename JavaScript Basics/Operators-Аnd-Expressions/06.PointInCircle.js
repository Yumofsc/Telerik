// 06. Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
// (x - center_x)^2 + (y - center_y)^2 < radius^2.
console.log('Task6');

var x = 0;
var y = 0;
console.log('Point coordinates['+ x +','+ y +']');

var circleX = 0;
var circleY = 0;
var radius = 5;

var result = (x - circleX)*(x - circleX) + (y - circleY)*(y - circleY) < radius*radius;
console.log('Is it point in the circle? ' + result);