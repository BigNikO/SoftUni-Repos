function diagonalSum(inputMatrix) {
  let start = 0;
  let end = inputMatrix.length - 1;
  let diagonalOne = 0;
  let diagonalTwo = 0;
  for (i = start; i <= end; i += 1) {
    diagonalOne += inputMatrix[i][i];
    diagonalTwo += inputMatrix[i][end - i];
  }
  console.log(diagonalOne + ' ' + diagonalTwo);
}

diagonalSum([[3, 5, 17], [-1, 7, 14], [1, -8, 89]]);
