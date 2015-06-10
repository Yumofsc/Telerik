/**Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 Return the elements in a JSON object.*/
console.log('TASK 7');

var url = 'http://telerikacademy.com/Courses/Courses/Details/239';

function parseURL(url) {
    var protocol = url.substr(0, url.indexOf(':')),
        server = url.substring(url.indexOf('/') + 2, url.indexOf('/', url.indexOf('/') + 2)),
        resource = url.substring(url.indexOf('/', url.indexOf('/') + 2)),
        result = {
            protocol: protocol,
            server: server,
            resource: resource
        }

        return result;
}

console.log(parseURL(url));