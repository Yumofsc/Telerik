/**Write a function for extracting all email addresses from given text.
 All sub-strings that match the format @… should be recognized as emails.
 Return the emails as array of strings.*/
console.log('TASK 09');

var text = 'Hello may name is Batman, my e-mail address is <batman@gmail.com>, Also you can find me on bruse_wane@gmail.com';

function emailExtractor(text){
    var extractor = [];
    extractor = text.match(/[A-z0-9._%]+@[A-z0-9]*.[A-z/]*/gi);
    return extractor;
}

console.log(emailExtractor(text.toString()));