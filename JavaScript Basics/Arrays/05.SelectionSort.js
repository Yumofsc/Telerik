/**Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm: Find the smallest element, move it at the first position,
 find the smallest from the rest, move it at the second position, etc.
 Hint: Use a second array*/

var array = [34, 17, 23, 35, 45, 9, 1],
    temp = 0;

for (var i = 0; i < array.length; i++) {
   for (var j = i + 1; j < array.length; j++) {
       if (array[i] > array[j]){
           temp = array[j];
           array[j] = array[i];
           array[i] = temp;
       }
   }
}
console.log(array.join(', '));
