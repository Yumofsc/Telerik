// 07. Write an expression that checks if given positive integer number n (n ? 100) is prime.
console.log('Task7');

var number = 59;
var isPrime = true;

for (i=2; i < Math.sqrt(number); i++) {
    if (number % i === 0) {
        isPrime = false;
    }
}
console.log('Is it number prime? ' + isPrime);
