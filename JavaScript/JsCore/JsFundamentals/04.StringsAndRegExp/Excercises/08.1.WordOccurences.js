function wordOccurences(sentence, word) {
  word = '\\b' + word + '\\b';
  let regexPattern = new RegExp(word, 'gi');
  if (sentence.match(regexPattern)) {
    console.log(sentence.match(regexPattern).length);
  } else {
    console.log(0);
  }
}

wordOccurences(
  'The waterfall was so high, that the child couldn’t see its peak.',
  'the'
);
