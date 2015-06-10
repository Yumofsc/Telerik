/**Write a script that finds the maximal sequence of equal elements in an array.
 * input	                   | result
 2, 1, 1, 2, 3, 3, 2, 2, 2, 1  | 2, 2, 2*/
console.log('TASK 3');

var array = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
var start = [];
var longest = [];

for (var i=0; i < array.length; i++) {
    if (start[0] !== array[i]){
        start = [array[i]];
    }
    else {
        start.push(array[i])
    }
    if (longest.length <=start.length){
        longest = start;
    }
}
console.log(longest.join(', '));