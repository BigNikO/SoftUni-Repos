function nonSubesequenceFromArray(inputArray) {
  console.log(inputArray[0]);
  maxValue = inputArray[0];
  if (maxValue !== undefined) {
    for (let index = 1; index < inputArray.length; index++) {
      if (inputArray[index] >= maxValue) {
        console.log(inputArray[index]);
        maxValue = inputArray[index];
      }
    }
  }
}

// nonSubesequenceFromArray([1, 3, 8, 4, 10, 12, 3, 2, 24]);
// nonSubesequenceFromArray([20, 3, 2, 15, 6, 1]);
