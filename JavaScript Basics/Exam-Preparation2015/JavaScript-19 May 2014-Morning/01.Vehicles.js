/**
 * Created by Yumo on 9.6.2015 ã..
 */


function solve(params) {
    var s = parseInt(params[0]);
    var count = 0,
        car = 4,
        truck = 10,
        trike = 3;

    for (var i = 0; i <= s; i += trike) {
        for (var j = 0; j <= s; j += car){
            for (var k = 0; k <= s; k += truck) {
                if ((i + j + k) === s) {
                    count ++;
                }
            }
        }
    }
    console.log(count);
}
solve(['400']);
