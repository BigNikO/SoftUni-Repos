function printLetters(letters) {
  for (let letterIndex = 0; letterIndex < letters.length; letterIndex += 1) {
    console.log(`str[${letterIndex}] -> ${letters[letterIndex]}`);
  }
}
printLetters('Hello World');
