/*03. Write a script that finds the max and min number from a sequence of numbers.*/
console.log('TASK 3');

var sequence = [12, 233, 43, 54, 4, 67, 32, 75, 34, 7, 87, 64, 10, 34],
    maxValue = 0,
    minValue = 1000;

for (var i = 0; i < sequence.length; i++) {
    if (sequence[i] >= maxValue) {
        maxValue = sequence[i];
    }
    if (sequence[i] <= minValue) {
        minValue = sequence[i];
    }
}
console.log('Min value: ' + minValue);
console.log('Max value: ' + maxValue);