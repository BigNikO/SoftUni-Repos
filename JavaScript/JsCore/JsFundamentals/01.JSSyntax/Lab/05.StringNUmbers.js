function stringNumbers(stringNumber) {
  let result = '';
  for (let index = 1; index <= +stringNumber; index++) {
    result += index;
  }
  return result;
}

stringNumbers('11');
