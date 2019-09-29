function matchTheDates(input) {
  let regex = new RegExp(/\b([\d]{1,2})-([A-Z][a-z]{2})-([\d]{4})\b/g);
  let match;
  for (let i = 0; i < input.length; i++) {
    while ((match = regex.exec(input[i]))) {
      console.log(
        `${match[0]} (Day: ${match[1]}, Month: ${match[2]}, Year: ${match[3]})`
      );
    }
  }
}

matchTheDates([
  'I am born on 30-Dec-1994.',
  'This is not date: 512-Jan-1996.',
  'My father is born on the 29-Jul-1955.',
]);
