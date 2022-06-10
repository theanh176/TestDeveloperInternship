// Cho mảng 2 chiều
var X0 = [01, 02, 03, 04, 05, 06, 07, 08, 09]
var X1 = [11, 12, 13, 14, 15, 16, 17, 18, 19]
var X2 = [21, 22, 23, 24, 25, 26, 27, 28, 29]
var X3 = [31, 32, 33, 34, 35, 36, 37, 38, 39]
var X4 = [41, 42, 43, 44, 45, 46, 47, 48, 49]
var X5 = [51, 52, 53, 54, 55, 56, 57, 58, 59]
var X6 = [61, 62, 63, 64, 65, 66, 67, 68, 69]
var X7 = [71, 72, 73, 74, 75, 76, 77, 78, 79]

// Tìm Tổ hợp
// [01, 11, 21], [01, 11, 22], [01, 11, 23], ...

var as2D = [X0, X1, X2, X3, X4, X5, X6, X7]


// Đệ quy

var arr = [];
var temp = [];
function trySort(x){
    for(let i = 0; i < as2D[0].length; i++){
        temp.push(as2D[x][i]);
        if(x < as2D.length-1)
            trySort(x + 1);
        else{
            arr.push([...temp]);
            temp.pop();
        }
    }
    temp.pop();
}
trySort(0);
console.log(arr)