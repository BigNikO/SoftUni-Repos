function nonSubesequenceFromArray(inputArray) {
  console.log(
    inputArray
      .filter(
        (element, index, array) =>
          (element >= array[0] && element >= array[index - 1]) || index === 0
      )
      .join('\n')
  );
}

// nonSubesequenceFromArray([1, 3, 8, 4, 10, 12, 3, 2, 24]);
// nonSubesequenceFromArray([20, 3, 2, 15, 6, 1, 24, 24]);
// nonSubesequenceFromArray([]);
