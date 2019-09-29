function concatenateAndReverse(stringArray) {
  let result = '';
  stringArray.forEach(element => {
    result += element;
  });
  console.log(
    result
      .split('')
      .reverse()
      .join('')
  );
}

concatenateAndReverse(['a', 'b', 'e']);
