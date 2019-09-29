function variableNamesInSentence(inputString) {
  let regexPattern = /\b_[a-zA-Z\d]+\b/g;
  console.log(
    inputString
      .match(regexPattern)
      .map(element => element.slice(1))
      .join(',')
  );
}

variableNamesInSentence(
  '__invalidVariable _evenMoreInvalidVariable_ _validVariable'
);
variableNamesInSentence('The _id and _age variables are both integers.');
