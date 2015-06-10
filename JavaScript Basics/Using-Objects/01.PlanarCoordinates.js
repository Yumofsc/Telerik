/**Write functions for working with shapes in standard Planar coordinate system.
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points.
 Check if three segment lines can form a triangle.*/
console.log('TASK 1');

function point(x, y) {
    return {
        coordX: x,
        coordY: y,
        toString: function pointCoordinates() {
            return '(' + this.coordX + ", " + this.coordY + ')';
        }
    }
}

function line(a, b) {
    return {
        lineA: a,
        lineB: b,
        toString: function lineFirstLastPoint() {
            return '(' + this.lineA + ", " + this.lineB + ')';
        }
    }
}
//Create Points
var firstPoint = point(21, 23),
    secondPoint = point(17, 28),
    thirdPoint = point(12, 25),
    fourthPoint = point(7, 20),
    fifthPoint = point(21, 35),
    sixthPoint = point(12, 32);

console.log(firstPoint.toString());
console.log(secondPoint.toString());
console.log(thirdPoint.toString());
console.log(fourthPoint.toString());
console.log(fifthPoint.toString());
console.log(sixthPoint.toString());


//Calculate the distance between two points.
function lineDistance(firstPoint, secondPoint) {
    return {
        distance: Math.sqrt(Math.pow((secondPoint.coordX - firstPoint.coordX), 2) + Math.pow((secondPoint.coordY - firstPoint.coordY), 2))
    }
}

//Create Lines
var firsLine = lineDistance(firstPoint, secondPoint),
    secondLine = lineDistance(thirdPoint, fourthPoint),
    thirdLine = lineDistance(fifthPoint, sixthPoint);

console.log(firsLine);
console.log(secondLine);
console.log(thirdLine);
console.log('----------------------------------');

//Checking if three segment lines can form a triangle.
function canLinesFormTriangle(line1, line2, line3) {
    if (line1 + line2 > line3 && line1 + line3 > line2 && line2 + line3 > line1) {
        return'The lines CAN form a triangle';
    }
    else {
        return 'The lines can NOT form a triangle';
    }
}

console.log(canLinesFormTriangle(firsLine, secondLine, thirdLine));