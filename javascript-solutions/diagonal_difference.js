function diagonalDifference(arr) {
    let left = 0;
    let right = 0;

    for(let i = 0; i < arr.length; i++){
        let lastIndex = (arr[i].length - 1) - i;

        left += arr[i][i]; // left to right diagonal
        right += arr[i][lastIndex];  // right to left diagonal
    }

    return Math.abs(left - right);
}

function main() {
    let arr = [
        [1, 2, 3],
        [4, 5, 6],
        [9, 8, 9]
    ];

    const result = diagonalDifference(arr);
    console.log(result);
}
