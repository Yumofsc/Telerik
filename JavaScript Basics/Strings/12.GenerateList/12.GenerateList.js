/**Write a function that creates a HTML <ul> using a template for every HTML <li>.
 The source of the list should be an array of elements.
 Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.*/
console.log('TASK 12');

var people = [
        {name: 'Batman', age: 34},
        {name: 'Robin', age: 22},
        {name: 'Gandalf', age: 125},
        {name: 'MechoPuh', age: 12},
        {name: 'John!', age: 31}
    ],
    template = document.getElementById('list-item').innerHTML;

function generateList() {
    var ul = document.createElement('ul');

    for (var i in people) {
        var li = document.createElement('li');
        li.innerHTML = format(template, people[i]);
        ul.appendChild(li);
    }
    document.body.appendChild(ul);
};

function format(string, person) {
    return string.replace(/\-{(\w+)\}-/g, function (match, prop) {
        return person[prop] || '';
    });
}