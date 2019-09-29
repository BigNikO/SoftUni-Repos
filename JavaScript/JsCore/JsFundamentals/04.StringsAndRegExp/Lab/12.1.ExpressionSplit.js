function expressionSplit([input]) {
  let regex = /[\s.,|;\)\(]+/;
  console.log(input.split(regex).join('\n'));
}

expressionSplit(['let sum = 1 + 2;if(sum > 2){\tconsole.log(sum);}']);
