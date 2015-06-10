// 05. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
console.log('Task5');

var bitNumber = 0001010011011111; // Enter Bit Number.
var thirdBit = bitNumber >> 3 & 1;

console.log('Which digit is bit 3 (1 or 0) ' + thirdBit);