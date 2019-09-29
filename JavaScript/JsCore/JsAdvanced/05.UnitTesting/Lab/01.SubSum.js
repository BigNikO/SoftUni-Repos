function subsum(arr, startIndex, endIndex) {
  if (startIndex < 0) {
    startIndex = 0;
  }

  if (!Array.isArray(arr)) {
    return NaN;
  }

  let sum = 0;

  arr.forEach(x => {
    sum += Number(x);
  });

  if (sum === NaN) {
    return sum;
  }

  const lastIndex = endIndex > arr.length ? arr.length : endIndex + 1;

  const result = arr.slice(startIndex, lastIndex);

  return result.reduce((a, b) => Number(a) + Number(b), 0);
}

subsum([10, 'twenty', 30, 40], 0, 2);
subsum([10, 20, 30, 40, 50, 60], 3, 300);
subsum([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1);
subsum([10, 'twenty', 30, 40], 0, 2);
subsum([], 1, 2);
module.exports = subsum;
