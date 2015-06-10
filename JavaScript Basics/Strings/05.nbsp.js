/**Write a function that replaces non breaking white-spaces in a text with '&nbsp';*/
console.log('TASK 05');

var text = 'Write a function that replaces non breaking white-spaces in a text      ',
    word = '&nbsp';

function replace(text, word) {
    var newText = text.replace(/\s/g, word);
    return newText;
}
console.log(replace(text, word));