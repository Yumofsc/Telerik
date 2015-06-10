/**Write a function that checks if the element at given position in given array of integers
 * is bigger than its two neighbours (when such exist).*/
console.log('TASK 6');

var arr = [4, 5, 6, 6, 7, 8, 9, 6, 3, 6, 7, 12, 53, 3, 3, 7, 6],
    index = 6;

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
console.log(checkBiggestOfNeighbours(arr, index));