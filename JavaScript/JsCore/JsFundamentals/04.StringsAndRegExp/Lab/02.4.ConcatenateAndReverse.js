function concatenateAndReverse(stringArray) {
  console.log(
    stringArray
      .join('')
      .split('')
      .reverse()
      .join('')
  );
}

concatenateAndReverse(['a', 'b', 'c']);
