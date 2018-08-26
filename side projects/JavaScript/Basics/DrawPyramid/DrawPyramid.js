'use strict';
exports.__esModule = true;
var lineCount = 4;
var a = " ";
var b = "*";
for (var i = 0; i < lineCount; i++) {
    for (var j = i; j < lineCount - 1; j++) {
        a += ' ';
    }
    console.log(a + b);
    a = ' ';
    b += '**';
}
