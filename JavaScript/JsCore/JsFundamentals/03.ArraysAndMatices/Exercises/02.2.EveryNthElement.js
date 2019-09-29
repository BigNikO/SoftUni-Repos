function everyNthElement(inputArray) {
  console.log(
    inputArray
      .filter(
        (element, index) =>
          index !== inputArray.length - 1 &&
          index % inputArray[inputArray.length - 1] === 0
      )
      .join('\n')
  );
}
