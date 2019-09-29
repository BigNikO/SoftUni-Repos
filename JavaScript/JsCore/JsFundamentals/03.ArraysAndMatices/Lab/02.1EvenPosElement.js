function evenPosElement(array) {
  let result = [];
  for (i = 0; i < array.length; i += 2) {
    result.push(array[i]);
  }
  console.log(result.join(' '));
}

// evenPosElement([1, 2, 3, 4, 5, 6, 7]);
// evenPosElement([20, 30, 40]);
