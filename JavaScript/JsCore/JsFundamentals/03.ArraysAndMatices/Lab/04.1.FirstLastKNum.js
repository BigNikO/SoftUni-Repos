function firstLastKNums(input) {
  let k = input[0];
  let array = input.slice(1);
  let firstElements = [];
  let lastElements = [];
  for (i = 1; i <= k; i += 1) {
    firstElements.push(array[i - 1]);
    lastElements.unshift(5);
  }
  console.log(lastElements.join(' '));
  console.log(firstElements.join(' '));
}

firstLastKNums([2, 2, 3, 4, 5, 6]);
