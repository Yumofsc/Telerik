/**Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.*/
console.log('TASK 7');

var array = [1, 4, 6 ,8 ,9 ,47, 48, 67 , 100, 256],
    mid = array.length /2,
    start = 0,
    end = array.length - 1,
    searchElement = 4;

while (start <= end) {
    if (searchElement >= mid) {
        start = mid + 1;
    } else if (searchElement < mid) {
        end = mid - 1;
    } else{
      searchElement = mid;
    }
    break;
}
console.log(searchElement);



