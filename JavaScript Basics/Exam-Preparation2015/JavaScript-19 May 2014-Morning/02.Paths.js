/**
 * Created by Yumo on 10.6.2015 ã..
 */

function solve(params) {
    var size = params[0].split(' ').map(Number),
        rows = size[0],
        cols = size[1],
        matrix = params.slice(1).map(function (line) {
            return line.split(' ');
        }),
        col = 0,
        row = 0,
        sum = 0,
        visited = {};

    while (true) {
        if (col >= cols || row >= rows || col < 0 || row < 0) {
            return 'successed with ' + sum;
        }
        if (visited[row * 52 + 23 + col * 43 + 18] === 'V') {
            return 'failed at (' + row + ', ' + col + ')';
        }

        //Count sum
        sum = (Math.pow(2, row) + col) + sum;
        visited[row * 52 + 23 + col * 43 + 18] = 'V';

        //Move
        if (matrix[row][col] === 'ur') {
            row--;
            col++;
        }
        else if (matrix[row][col] === 'ul') {
            row--;
            col--;
        }
        else if (matrix[row][col] === 'dr') {
            row++;
            col++;
        }
        else if (matrix[row][col] === 'dl') {
            row++;
            col--;
        }
    }

    console.log(matrix);
}

var test1 = [
        '3 5',
        'dr dl dr ur ul',
        'dr dr ul ur ur',
        'dl dr ur dl ur'
    ],
    test2 = [
        '3 5',
        'dr dl dl ur ul',
        'dr dr ul ul ur',
        'dl dr ur dl ur'
    ];
solve(test1);
solve(test2);