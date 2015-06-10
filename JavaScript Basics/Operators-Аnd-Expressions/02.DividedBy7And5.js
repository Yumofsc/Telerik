// 02. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
console.log('Task2');

var number = 140; // Change number to test is the number divide by 7 and 5 or not

console.log(number);
number % 7 === 0 && number % 5 === 0 ? console.log('Number ' + number + ' CAN be divided by 7 and 5 in the same time') :
    console.log('Number ' + number + ' CAN NOT be divided by 7 and 5 in the same time');
