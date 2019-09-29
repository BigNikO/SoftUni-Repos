function rotateArray(input) {
  let rotations = input.pop() % input.length;
  for (i = 1; i <= rotations; i += 1) {
    input = input.map((element, index, array) => {
      if (index === 0) {
        return array[array.length - 1];
      } else {
        return array[index - 1];
      }
    });
  }
  console.log(input.join(' '));
}

// rotateArray([1, 2, 3, 4, 2]);
// rotateArray(['banana', 'orange', 'coconut', 'apple', 15]);
