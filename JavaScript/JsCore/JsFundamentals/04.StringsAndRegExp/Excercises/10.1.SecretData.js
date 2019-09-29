function secretData(inputLines) {
  namePattern = /(\*[A-Z][a-zA-Z]*)(?= |\t|$)/g;
  phonePatter = /(\+[0-9-]{10})(?= |\t|$)/g;
  iDPattern = /(![a-zA-Z0-9]+)(?= |\t|$)/g;
  basePattern = /(_[a-zA-Z0-9]+)(?= |\t|$)/g;
  for (line = 0; line < inputLines.length; line++) {
    inputLines[line] = replaceMatches(namePattern, inputLines[line]);
    inputLines[line] = replaceMatches(phonePatter, inputLines[line]);
    inputLines[line] = replaceMatches(iDPattern, inputLines[line]);
    inputLines[line] = replaceMatches(basePattern, inputLines[line]);
  }
  console.log(inputLines.join('\n'));

  function replaceMatches(pattern, line) {
    line = line.replace(pattern, element => '|'.repeat(element.length));
    return line;
  }
}

secretData([
  'Agent *Ivankov was in the room when it all happened.',
  'The person in the room was heavily armed.',
  'Agent *Ivankov had to act quick in order.',
  'He picked up his phone and called some unknown number. ',
  'I think it was +555-49-796',
  "I can't really remember...",
  'He said something about "finishing work" with subject !2491a23BVB34Q and returning to Base _Aurora21 ',
  'Then after that he disappeared from my sight.',
  'As if he vanished in the shadows.',
  'A moment, shorter than a second, later, I saw the person flying off the top floor.',
  "I really don't know what happened there.",
  'This is all I saw, that night.',
  'I cannot explain it myself...',
]);
