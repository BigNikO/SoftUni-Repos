function captureTheNumbers(input) {
  let regexPattern = /[0-9]+/g;
  let result = [];
  for (i = 0; i < input.length; i++) {
    if (input[i].match(regexPattern)) {
      result.push(input[i].match(regexPattern).join(' '));
    }
  }
  console.log(result.join(' '));
}
captureTheNumbers([
  'The300 ',
  'What is that?',
  'I think its the 3rd movie.',
  'Lets watch it at 22:45',
]);
