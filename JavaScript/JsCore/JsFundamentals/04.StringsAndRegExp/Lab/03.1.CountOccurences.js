function countOccurrences(targetText, text) {
  let counter = 0;
  let index = text.indexOf(targetText);
  while (index > -1) {
    counter += 1;
    index = text.indexOf(targetText, index + 1);
  }
  console.log(counter);
}
