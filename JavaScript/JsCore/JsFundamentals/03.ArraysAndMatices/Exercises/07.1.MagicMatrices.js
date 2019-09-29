function magicMatrices(matrix) {
  let isMagic = true;
  let magicSum = matrix[0].reduce((a, b) => a + b);
  for (row = 0; row < matrix.length; row += 1) {
    if (
      matrix[row].reduce((a, b) => a + b) !== magicSum ||
      matrix
        .map(element => element.filter((element, index) => index === row))
        .reduce((a, b) => Number(a) + Number(b)) !== magicSum
    ) {
      isMagic = false;
      break;
    }
  }
  console.log(isMagic);
}

magicMatrices([[4, 5, 6], [6, 5, 4], [5, 5, 5]]);
