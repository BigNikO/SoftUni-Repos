function capitalizeWords(inputString) {
  console.log(
    inputString
      .toLowerCase()
      .split(' ')
      .map(element => element[0].toUpperCase() + element.slice(1))
      .join(' ')
  );
}
capitalizeWords('Capitalize these words');
