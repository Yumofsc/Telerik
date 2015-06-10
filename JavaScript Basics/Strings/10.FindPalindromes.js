/**Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".*/
console.log('TASK 10');

var text = '"ABBA", "lamal", "exe", "sos", "kaval", "test"';

function isPlaindrome(word){
    var i,
        len;

    for(i = 0, len = word.length; i < len / 2; i+=1){
        if(word[i] !== word[word.length - i - 1]){
            return false;
        }
    }
    return true;
}

function extractPalindromes(text){
    var extracted = [],
        words = text.match(/\b\w+\b/g);

    for (var word in words){
        if (isPlaindrome(words[word])) {
            extracted.push(words[word])
         } 
    }
    return extracted.join(', ');
}
console.log(extractPalindromes(text));