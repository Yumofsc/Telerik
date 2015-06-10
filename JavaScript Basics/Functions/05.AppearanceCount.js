/**Write a function that counts how many times given number appears in given array.
 Write a test function to check if the function is working correctly.*/
console.log('TASK 5');

var array = [4 ,5 ,6 ,6 ,7, 8, 9, 6, 3 ,6 ,7 ,12, 53 ,3 , 3, 7, 6];
var number = 6;

function appearanceCount(array, number) {
    var counter = 0;
    for (var i = 0; i < array.length; i+=1) {
        if (number === array[i]) {
         counter += 1;
         }
    }
    return counter;
}
console.log('The number: ' + number + ' appears: ' + appearanceCount(array,number) + ' times');