function rotateArray(inputArray) {
  let rotations = inputArray.pop() % inputArray.length;
  for (let rotation = 0; rotation < rotations; rotation++) {
    let firstArrayElement = inputArray[inputArray.length - 1];
    inputArray.pop();
    inputArray.unshift(firstArrayElement);
  }
  console.log(inputArray.join(' '));
}
// rotateArray([1, 2, 3, 4, 2]);
// rotateArray(['banana', 'orange', 'coconut', 'apple', 15]);
