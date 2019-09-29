function sortArray(inputArray) {
  console.log(
    inputArray
      .sort()
      .sort((a, b) => a.length > b.length)
      .join('\n')
  );
}

// sortArray(['alpha', 'beta', 'gamma']);
// sortArray(['test', 'Deny', 'omen', 'Default']);
// sortArray(['Isaac', 'Theodor', 'Jack', 'Harrison', 'George']);
