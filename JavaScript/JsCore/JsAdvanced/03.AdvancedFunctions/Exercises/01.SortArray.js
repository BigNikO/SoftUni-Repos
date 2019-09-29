function sortArray(arr, command) {
  if (command === 'asc') {
    return arr.sort((a, b) => a - b);
  } else {
    return arr.sort((a, b) => b - a);
  }
}

console.log(sortArray([1, 44, 6, 2, 8], 'dsc'));
