/**
 * Created by Yumo on 9.6.2015 ã..
 */

function Solve(params) {
    var N = parseInt(params[0]),
        counter = 1,
        array = params.slice(1).map(Number);

    for (var i = 0; i < array.length; i+=1) {
        if (array[i +1] < array[i]) {
            counter++;
        }
    }
    return counter;
}


var test = ['7', '1', '2', '-3', '4', '4', '0', '1'],
    test1 = ['6', '1', '3', '-5', '8', '7', '-6'],
    test2 = ['9', '1', '8', '8', '7', '6', '5', '7', '7', '6'];

console.log(Solve(test) + ' expect ---> 3');
console.log(Solve(test1) + ' expect ---> 4');
console.log(Solve(test2) + ' expect ---> 5');