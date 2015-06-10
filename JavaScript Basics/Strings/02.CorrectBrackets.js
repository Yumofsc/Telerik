/**Write a JavaScript function to check if in a given expression the brackets are put correctly.
 Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).*/
console.log('TASK 2');

var text = ')(a+b))';
function isBracketsCorrect(expression) {
    var i,
        len,
        count = 0;

    for (i = 0, len = expression.length; i < len; i += 1) {
        if (expression[i] === '(') {
            count += 1;
        }
        else if (expression[i] === ')') {
            count -= 1;
        }
        if (count<0) {
          return false;
         }
       return true;
    }
}
console.log(isBracketsCorrect(text));