/**Write a function to count the number of div elements on the web page*/
console.log('TASK 4');

var element = 'div';

function elementCounter (element){
    return document.getElementsByTagName(element).length

}
console.log(element + ' element is found: ' + elementCounter(element) + ' times');