function repeatAStringNTimes(inputString, timesToRepeat) {
  let result = '';
  for (i = 0; i < timesToRepeat; i++) {
    result += inputString;
  }
  console.log(result);
}

repeatAStringNTimes('repeat', 5);
