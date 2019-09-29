function oddEven(number) {
  if (Math.ceil(number) !== number) {
    return 'invalid';
  }
  return number % 2 === 0 ? 'even' : 'odd';
}
