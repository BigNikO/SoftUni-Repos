function spiralMatrix(rows, cols) {
  let matrix = [];

  for (let row = 0; row < rows; row++) {
    matrix[row] = [];
    for (let col = 0; col < cols; col++) {
      matrix[row][col] = 0;
    }
  }

  let count = 0;
  let row = 0;
  let col = 0;

  while (count < rows * cols) {
    while (col < cols && matrix[row][col] == 0) {
      count++;
      matrix[row][col] = count;
      col++;
    }
    col--;
    row++;
    while (row < rows && matrix[row][col] === 0) {
      count++;
      matrix[row][col] = count;
      row++;
    }
    row--;
    col--;
    while (col >= 0 && matrix[row][col] === 0) {
      count++;
      matrix[row][col] = count;
      col--;
    }
    row--;
    col++;
    while (row >= 0 && matrix[row][col] === 0) {
      count++;
      matrix[row][col] = count;
      row--;
    }
    row++;
    col++;
  }
  console.log(matrix.map(element => element.join(' ')).join('\n'));
}
spiralMatrix(15, 7);
