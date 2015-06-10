/**Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
 Example:
 The target sub-string is in
 The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
 The result is: 9*/
console.log('TASK 3');

var text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.",
    word = 'in';

function wordContainInText(text, word) {
    var reg = new RegExp(word,'gi');
    var count = text.match(reg).length;
    return count
}
console.log(wordContainInText(text, word));