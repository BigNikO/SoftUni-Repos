function rounding(arr) {
  let numberToPrecise = arr[0];
  let precisingNumber = arr[1];
  Number(precisingNumber);
  if (precisingNumber > 15) {
    precisingNumber = 15;
  }
  let pricisedNumber = Number(numberToPrecise).toFixed(precisingNumber);
  console.log(Number(pricisedNumber));
}

rounding([10.5, 3]);
