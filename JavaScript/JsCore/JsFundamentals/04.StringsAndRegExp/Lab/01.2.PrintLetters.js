function printLetters(letters) {
  letters.split('').forEach((letter, indexLetter) => {
    console.log(`str[${indexLetter}] -> ${letter}`);
  });
}
printLetters('Hello World');
