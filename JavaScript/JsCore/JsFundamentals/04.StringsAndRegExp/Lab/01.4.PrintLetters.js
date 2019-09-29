function printLetters(letters) {
  console.log(
    letters
      .split('')
      .map((letter, index) => `str[${index}] -> ${letter}`)
      .join('\n')
  );
}
printLetters('Hello World');
