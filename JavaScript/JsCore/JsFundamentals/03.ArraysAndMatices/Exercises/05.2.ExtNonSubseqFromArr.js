// More pricese
function nonSubesequenceFromArray(inputArray) {
  maxValue = inputArray[0];
  result = [];
  if (maxValue != undefined) {
    result.push(maxValue);
    for (let index = 1; index < inputArray.length; index++) {
      if (inputArray[index] >= maxValue) {
        maxValue = inputArray[index];
        result.push(maxValue);
      }
    }
    console.log(result.join('\n'));
  }
}

// nonSubesequenceFromArray([1, 3, 8, 4, 10, 12, 3, 2, 24]);
// nonSubesequenceFromArray([20, 3, 2, 15, 6, 1,, 24, 24]);
// nonSubesequenceFromArray([]);
