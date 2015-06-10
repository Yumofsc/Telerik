/**Write a function that finds all the occurrences of word in a text.
 The search can be case sensitive or case insensitive.
 Use function overloading.*/
console.log('TASK 3');

var text = 'Bill is the first name of former U.S. president William Clinton,' +
        ' who could sign a bill which is a proposed law that was approved by Congress',
    word = 'bill',
    blank;


function wordOccurrencesInText(text, word, blank) {
    var argsLength = arguments.length;
    var counter = 0;
    if (argsLength === 2) {
        var lowerText = text.toLowerCase();
        var splitTextLower = lowerText.split(" ");
        for (var i = 0; i < splitTextLower.length; i++) {
            if (word === splitTextLower[i]) {
                counter++;
            }
        }
        return counter;
    }
    else if (argsLength === 3) {
        var splitTextUpper = text.split(" ");
        for (i = 0; i < splitTextUpper.length; i++) {
            if (word === splitTextUpper[i]) {
                counter++;
            }
        }
        return counter;
    }
}
console.log('word: ' + word + ' found: ' + wordOccurrencesInText(text, word) + ' times');
console.log('word: ' + word + ' found: ' + wordOccurrencesInText(text, word, blank) + ' times');