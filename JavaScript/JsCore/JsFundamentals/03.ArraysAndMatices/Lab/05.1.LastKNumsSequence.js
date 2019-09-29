function lastKNumsSeq(number, k) {
  let result = [1];
  for (i = 1; i < number; i += 1) {
    let startIndex = Math.max(i - k);
    let sumElements = result.slice(startIndex, i).reduce((a, b) => a + b);
    result.push(sumElements);
  }
  console.log(result.join(' '));
}

// lastKNumsSeq(8, 2);
