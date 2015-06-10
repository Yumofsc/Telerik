/** Write a function that returns the index of the first element in array that is larger than its neighbours or -1,
 if there’s no such element.
 Use the function from the previous exercise.*/
console.log('TASK 7');

var arr = [4, 5, 6, 6, 7, 8, 9, 6, 3, 6, 7, 12, 53, 3, 3, 7, 6];
var arr2 = [1, 1, 1, 1]; // IF YOU WANT TO TRY WITH -> "NO SUCH ELEMENT!

function checkBiggestOfNeighbours(array, index) {
    var isTrue = true;

    if (index === 0) {
        if (array[index] > array[index + 1]) {
            return isTrue;
        }
        return !isTrue;
    }
    else if (index === array.length - 1) {
        if (array[index] > array[index - 1]) {
            return isTrue;
        }
        return !isTrue;
    }
    else {
        if (array[index] > array[index + 1] && array[index] > array[index - 1] ) {
            return isTrue;
        }
        return !isTrue;
    }
}


function firstLargerThanNeighbours(array) {
    var index,
        len;
    for (index = 0, len = array.length; index < len; index += 1) {
        if(checkBiggestOfNeighbours(array, index)){
            return array[index]
        }
    }
    return -1;
}
console.log('First element larger than his neighbours is: ' + firstLargerThanNeighbours(arr));

