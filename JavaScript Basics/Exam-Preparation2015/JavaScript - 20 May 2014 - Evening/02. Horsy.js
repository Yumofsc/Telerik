/**
 * Created by Yumo on 10.6.2015 ã..
 */

function solved(args) {
    var size = args[0].split(' ').map(Number),
        field = args.slice(1).map(Number),
        rows = size[0],
        cols = size[1],
        row = rows - 1,
        col = cols - 1,
        jumps = 0,
        used = {},
        points = 0,
        directions = [[-2, 1], [-1, 2], [1, 2], [2, 1],
            [2, -1], [1, -2], [-1, -2], [-2, -1]];

    function getValue(row, col) {
        return Math.pow(2, row) - col;
    }

    function hash(row, col, cols) {
        return row * cols + col;
    }

    while (true) {
        if (row > rows || col > cols || col < 0 || row < 0) {
            console.log('Go go Horsy! Collected ' + points + ' weeds');
            break;
        }
        if (used[hash(row, col, cols)]) {
            return 'Sadly the horse is doomed in ' + jumps + ' jumps';
        }


        used[hash(row, col, cols)] = true;

        jumps++;
        points += getValue(row, col);

        var dirIndex = field[row][col],
            dir = directions[dirIndex];


    }

    //console.log(nextJump(0, 1));
}


var test1 = ['3 5', '54561', '43328', '52388'];
solved(test1);