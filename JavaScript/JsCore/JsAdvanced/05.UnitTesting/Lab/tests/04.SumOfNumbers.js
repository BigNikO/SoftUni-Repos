const { assert } = require('chai');
const sum = require('../04.SumOfNumbers');

describe('sum(arr)', () => {
  it('should returns the sum of the array elements', () => {
    const arr = [1, 2, 3, 4];
    const expectedResult = 10;
    const currentResult = sum(arr);
    assert.equal(currentResult, expectedResult);
  });

  it('should returns NaN if the array contains a string', () => {
    const arr = [1, 'string', 3, 4];
    const currentResult = sum(arr);
    assert.isNaN(currentResult);
  });

  it('should throws an error if the function argument is not an array', () => {
    const input = null;
    assert.throws(() => sum(input));
  });

  it('should returns 0 if the array is empty', () => {
    const arr = [];
    expectedResult = 0;
    currentResult = sum(arr);
    assert.equal(currentResult, expectedResult, '[message]');
  });
});
