function figure(number) {
  if (number===2){
    console.log("+++")
    return;
  }
  let kindOfLine = (num, str1, str2) => {
    let result = "";
    for (let i = 2; i < num; i++) {
      result += str2;
    }
    result += str1;
    return result;
  };

  let firstKindOfLine = "+" +
    kindOfLine(number, "+", "-") +
    kindOfLine(number, "+", "-");
  let secondKindLine = "|" +
    kindOfLine(number, "|", " ") +
    kindOfLine(number, "|", " ");

  console.log(firstKindOfLine);
  for (let i = 2; i < Number(number)/2; i++) {
    console.log(secondKindLine);
  }
  console.log(firstKindOfLine);
  for (let i = 2; i < Number(number)/2; i++) {
    console.log(secondKindLine);
  }
  console.log(firstKindOfLine);
}

figure(5);
figure(7);
figure(9);
figure(4);
figure(6);
figure(8);
figure(2);


