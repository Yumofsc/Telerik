/** Write a script that compares two char arrays lexicographically (letter by letter).*/
console.log('TASK 2');

var firstArr = ['1', 'u', 'p', 'p', 'o', 'r', 't', 't'];
var secondArr = ['2', 'i', 'r','p', 'o', 'r', 't', 't'];

if (firstArr.length > secondArr.length) {
    console.log('Lexicographically order: FirstArray > SecondArray');
}
else if (firstArr.length == secondArr.length) {
    for (var i = 0; i < firstArr.length; i++) {
        if (firstArr[i] > secondArr[i]) {
            console.log('First array is first');
            break;
        }
        else {
            console.log('Second array is first');
            break;
        }
    }
}
else {
    console.log('Lexicographically order: SecondArray > FirstArray ');
}

