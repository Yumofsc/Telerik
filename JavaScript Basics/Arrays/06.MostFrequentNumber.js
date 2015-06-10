/**Write a script that finds the most frequent number in an array.
 input	                                 |result
 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	 |4 (5 times)*/
console.log('TASK 6');

var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
var counter = 0;
var max = 0;
var number = 0;


for (var i = 0; i < array.length; i++) {
    counter = 1;
    for (var j = i + 1; j < array.length; j++) {
        if (array[i] === array[j]) {
            counter++;
            if (counter > max) {
                max = counter;
                number = i
            }
        }
    }
}
console.log('The number ' + array[number] + '(' + max + ' times)');