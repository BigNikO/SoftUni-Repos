const subsum = require('../01.SubSum');
let { assert } = require('chai');

describe('subsum(arr)', () => {
  it('Should return NaN if the first element is not an array', () => {
    const array = 1;
    const firstIndex = 2;
    const secondIndex = 3;
    const result = subsum(array, firstIndex, secondIndex);
    assert.isNaN(result);
  });

  it('Should return transform the first array element to 0 if it is lower', () => {
    const array = [10, 20, 30, 40, 50, 60];
    const firstIndex = -3;
    const secondIndex = 300;
    const result = subsum(array, firstIndex, secondIndex);
    const expectedResult = subsum(array, 0, secondIndex);
    assert.equal(result, expectedResult);
  });

  it('If the end index is outside the bounds of the array, assume it points to the last index of the array', () => {
    const array = [10, 20, 30, 40, 50, 60];
    const firstIndex = 3;
    const secondIndex = 150;
    const result = subsum(array, firstIndex, secondIndex);
    const expectedResult = 150;
    assert.equal(result, expectedResult);
  });
});
