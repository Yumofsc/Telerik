/**Write a script that finds the maximal increasing sequence in an array.
 * Example:
 input	               |result
 3, 2, 3, 4, 2, 2, 4   |2, 3, 4*/
console.log('TASK 4');

var array = [3, 2, 3, 4, 2, 2, 4 ];
var temp = [];
var sequence= [];
var i = 0;


for (i; i < array.length; i++) {
    if (array[i] < array[i + 1]) {
        temp.push(array[i + 1]);
    }
    else {

        temp = [array[i +1]]
    }
    if (temp.length >= sequence.length){
       sequence = temp;
    }
}

console.log(sequence.join(', '));