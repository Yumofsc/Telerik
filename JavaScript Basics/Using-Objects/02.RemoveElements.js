/**Write a function that removes all elements with a given value.
 Attach it to the array type.
 Read about prototype and how to attach methods.*/
console.log('TASK 2');

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'],
    element = 1;

Array.prototype.remove = function removeElementsFromArray(array, element) {
    var i,
        len,
        result = [];

    for (i = 0, len = array.length; i < len; i++) {
        if (element !== array[i]) {
            result.push(array[i])
        }
    }
    return result.join(', ')
}

console.log(arr.remove(arr, element));