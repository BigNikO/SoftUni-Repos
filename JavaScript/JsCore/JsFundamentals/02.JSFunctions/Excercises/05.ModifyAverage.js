function modifyAverage(number) {
  number = number.toString();
  function getAverage(number) {
    let sum = 0;
    for (let digit of number) {
      sum += Number(digit);
    }
    return sum / number.length;
  }
  let average = getAverage(number);
  let addNine = addMore => (addMore += 9);

  while (average <= 5) {
    number = addNine(number);
    average = getAverage(number);
  }
  console.log(number);
}

modifyAverage('111');
