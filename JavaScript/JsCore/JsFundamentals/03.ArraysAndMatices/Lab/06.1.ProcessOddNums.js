function processOddNums(input) {
  let result = [];
  for (i = 1; i < input.length; i += 2) {
    result.unshift(input[i] * 2);
  }
  console.log(result.join(' '));
}

function processOddNumbers(input) {
  console.log(
    input
      .filter((element, index) => index % 2 === 1)
      .map(element => (element = element * 2))
      .reverse()
      .join(' ')
  );
}
processOddNums([10, 15, 20, 25]);
processOddNumbers([10, 15, 20, 25]);
