function calculateSumAndVAT(input) {
  let sum = 0;
  input.forEach(element => (sum += element));
  let VAT = 0.2 * sum;
  let total = VAT + sum;
  console.log(`sum = ${sum}\nVAT = ${VAT}\ntotal = ${total}`);
}

calculateSumAndVAT([3.12, 5, 18, 19.24, 1953.2262, 0.001564, 1.1445]);
calculateSumAndVAT([1.2, 2.6, 3.5]);
