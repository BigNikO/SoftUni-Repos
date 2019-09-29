function printLetters(letters) {
  let result = [];
  letters.split('').forEach((letter, indexLetter) => {
    result.push(`str[${indexLetter}] -> ${letter}`);
  });
  console.log(result.join('\n'));
}
printLetters('Hello World');
