function printLetters(letters) {
  letters.split('').map((letter, indexLetter) => {
    console.log(`str[${indexLetter}] -> ${letter}`);
  });
}
printLetters('Hello World');
