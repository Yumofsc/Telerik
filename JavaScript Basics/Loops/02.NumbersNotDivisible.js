/*02. Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time */
console.log('TASK 2');

var n = 43;

for (var i = 0; i < n; i++) {
    if (i % 21) {
        console.log(i);
    }

}