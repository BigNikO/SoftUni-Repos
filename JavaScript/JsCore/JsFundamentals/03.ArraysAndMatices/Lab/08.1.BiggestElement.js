function biggestElement(inputArrays) {
  let concatArray = [inputArrays[0]];
  for (i = 0; i < inputArrays.length; i += 1) {
    concatArray = concatArray.concat(inputArrays[i]);
  }
  console.log(
    concatArray
      .sort((a, b) => a - b)
      .slice(concatArray.length - 1)
      .join('')
  );
}

biggestElement([[3, 5, 7, 12], [-1, 4, 33, 2], [8, 3, 0, 4]]);
