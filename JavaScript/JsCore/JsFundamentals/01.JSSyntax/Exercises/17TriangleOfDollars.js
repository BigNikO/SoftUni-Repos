function triangleOfDollars(number) {
  let result ="";
  for (let i = 0; i < number; i++) {
    for (let j = 0; j <= i; j++) {
      result += "$";
    }
    console.log(result);
    result=""
  }
}

// triangleOfDollars(5);