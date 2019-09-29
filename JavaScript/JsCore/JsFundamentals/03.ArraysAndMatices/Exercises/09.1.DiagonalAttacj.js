function diagonalAttack(input) {
  let end = input.length - 1;
  diagonalOneSum = 0;
  diagonalTwoSum = 0;
  diagonal = [];
  for (i = 0; i < input.length; i += 1) {
    input[i] = input[i].split(' ');
    diagonalOneSum += Number(input[i][i]);
    diagonalTwoSum += Number(input[i][end - i]);
  }
  if (diagonalOneSum == diagonalTwoSum) {
    for (row = 0; row < input.length; row += 1) {
      for (col = 0; col < input[row].length; col += 1) {
        if (row !== col && end - row !== col) {
          input[row][col] = diagonalOneSum;
        }
      }
    }
  }
  console.log(input.map(element => element.join(' ')).join('\n'));
}
diagonalAttack([
  '5 3 12 3 1',
  '11 4 23 2 5',
  '101 12 3 21 10',
  '1 4 5 2 2',
  '5 22 33 11 1',
]);

diagonalAttack(['1 1 1', '1 1 1', '1 1 0']);
