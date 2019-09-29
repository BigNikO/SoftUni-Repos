function negativePositive(array) {
  newArray = [];
  for (i = 0; i < array.length; i += 1) {
    if (array[i] < 0) {
      newArray.unshift(array[i]);
    } else {
      newArray.push(array[i]);
    }
  }
  console.log(newArray.join('\n'));
}

negativePositive([3, -2, 0, -1]);
