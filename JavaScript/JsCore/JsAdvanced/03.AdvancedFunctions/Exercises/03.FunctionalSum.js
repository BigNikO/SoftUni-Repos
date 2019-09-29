const getSum = (function getSum() {
  let sum = 0;
  return function add(numberToAdd) {
    sum += numberToAdd;
    add.toString = function() {
      return sum;
    };
    return add;
  };
})();

console.log(getSum(1)(5)(-2).toString());
