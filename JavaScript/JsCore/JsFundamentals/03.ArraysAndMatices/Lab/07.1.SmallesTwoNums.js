function smallestTwoNums(inputArray) {
  console.log(
    inputArray
      .sort((a, b) => a - b)
      .slice(0, 2)
      .join(' ')
  );
}
smallestTwoNums([10, 20, 7, 8, 66, 3, 1, 4, 5]);
