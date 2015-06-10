/**
 * Created by Yumo on 9.6.2015 ã..
 */
function solve(params) {
    var s = +params[0],
        c1 = +params[1],
        c2 = +params[2],
        c3 = +params[3],
        answer = 0;

    for (var i = 0; i <= (s / c1)+ 1; i += 1) {
        for (var j = 0; j <= (s / c2)+ 1; j += 1) {
            for (var k = 0; k <= (s / c3)+1; k += 1) {
                var result = (i * c1) + (j * c2) + (k * c3);
                if (result <= s) {
                    answer = Math.max(answer, result)
                }
                else {
                    break
                }
            }
        }
    }
    console.log(answer);
}
solve(['110', '13', '15', '17']);