/**
 * Created by Yumo on 9.6.2015 ã..
 */

function Solve(params) {
    var N = parseInt(params[0]);
    var bestSum = -2000000,
        array = [];
    array = params.slice(1).map(Number);

    for (var i = 0; i < array.length; i += 1) {
        var sum = 0;
        for (var j = i; j < array.length; j += 1) {
            sum += array[j];
            if (bestSum < sum) {
                bestSum = sum;
            }
        }
    }

    console.log(bestSum);
}
var test = ['8', '1', '6', '-9', '4', '4', '-2', '10', '-1'];
var test2 = [ '9', ',-9', '-8', '-8', '-7', '-6', '-5', '-1', '-7', '-6'];

Solve(test);
Solve(test2);