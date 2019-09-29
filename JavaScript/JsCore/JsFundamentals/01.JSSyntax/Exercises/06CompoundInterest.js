function compoundInterest(arr) {
  let principalSum = arr[0];
  let interestRate = arr[1] / 100;
  let compoudingPeriod = 12 / arr[2];
  let totalTimeSpan = arr[3];
  let result =
    principalSum *
    Math.pow(
      1 + interestRate / compoudingPeriod,
      compoudingPeriod * totalTimeSpan
    );
  console.log(result);
}

compoundInterest([1500, 4.3, 3, 6]);
