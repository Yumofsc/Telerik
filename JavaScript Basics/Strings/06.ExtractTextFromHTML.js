/**Write a function that extracts the content of a html page given as text.
 The function should return anything that is in a tag, without the tags.*/
console.log('TASK 06');

var html = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';

function getTextFromHTML(text){
    var newText = text.replace(/(<[^>]+>)/ig, '');
    return  newText;
}
console.log(getTextFromHTML(html));