/**Write a function that formats a string using placeholders.
 The function should work with up to 30 placeholders and all types. */
console.log('TASK 11');

console.log(format('{0}, {1}, {0} text {2}',  1, 'Pesho', 'Gosho'));

function format(){
    var args = arguments,
        string = args[0],
        placeholder;

    for (var ind = 1; ind < args.length; ind++) {
        placeholder ='{' + (ind - 1) + '}';

        while(string.indexOf(placeholder) > -1) {
            string = string.replace(placeholder, args[ind]);
        }
    }

    return string;
}
