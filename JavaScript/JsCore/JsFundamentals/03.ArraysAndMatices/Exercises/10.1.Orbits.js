function orbit([rows, cols, startRow, startCol]) {
  let matrix = [];
  for (let i = 0; i < rows; i++) {
    matrix[i] = [];
    for (j = 0; j < cols; j++) {
      matrix[i][j] = 0;
    }
  }
  for (let i = 0; i < matrix.length; i++) {
    for (j = 0; j < matrix.length; j++) {
      matrix[i][j] =
        Math.max(Math.abs(startRow - i), Math.abs(startCol - j)) + 1;
    }
  }
  console.log(matrix.map(element => element.join(' ')).join('\n'));
}
orbit([3, 3, 2, 2]);
