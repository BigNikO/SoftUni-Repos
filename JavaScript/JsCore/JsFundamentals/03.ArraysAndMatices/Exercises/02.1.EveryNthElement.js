function everyNthElement(inputArray) {
  console.log(inputArray[0]);
  for (index = 1; index < inputArray.length - 1; index++) {
    if (index % inputArray[inputArray.length - 1] === 0) {
      console.log(inputArray[index]);
    }
  }
}

everyNthElement([1, 2, 3, 4, 5, 6, 7, 8, 9, 3]);
