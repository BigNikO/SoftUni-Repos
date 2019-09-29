function concatenateAndReverse(stringArray) {
  string = stringArray.reduce((a, b) => a + b);
  result = '';
  for (i = string.length - 1; i >= 0; i -= 1) {
    result += string[i];
  }
  console.log(result);
}
concatenateAndReverse(['a', 'b', 'c']);
