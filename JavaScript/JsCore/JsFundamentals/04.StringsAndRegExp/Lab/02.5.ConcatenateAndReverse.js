function concatenateAndReverse(stringArray) {
  console.log(
    Array.from(stringArray.join(''))
      .reverse()
      .join('')
  );
}
concatenateAndReverse(['a', 'b', 'c']);
