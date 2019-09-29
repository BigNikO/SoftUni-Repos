function concatenateAndReverse(stringArray) {
  console.log(
    stringArray
      .reduce((a, b) => a + b)
      .split('')
      .reverse()
      .join('')
  );
}
