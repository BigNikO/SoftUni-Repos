function processOddNumbers(input) {
  console.log(
    input
      .filter((element, index) => index % 2 === 1)
      .map(element => (element = element * 2))
      .reverse()
      .join(' ')
  );
}
processOddNumbers([10, 15, 20, 25]);
