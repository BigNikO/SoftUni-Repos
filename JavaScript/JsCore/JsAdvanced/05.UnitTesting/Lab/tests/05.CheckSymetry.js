const { assert } = require('chai');
const isSymmetric = require('../05.CheckForSymetry');

describe('Check for symetric function', () => {
  it('Should return false if the input is not an array', () => {
    const input = 'String';
    const result = isSymmetric(input);
    assert.isFalse(result, '[message]');
  });

  it('Should return true if the array is symetric', () => {
    const inputArray = [5, 8, 2, 2, 8, 5];
    const result = isSymmetric(inputArray);
    assert.isTrue(result, '[message]');
  });

  it('Should return true', () => {
    const inputArray = [];
    const result = isSymmetric(inputArray);
    assert.isTrue(result, '[message]');
  });

  it('Should return true', () => {
    const inputArray = ['str', { x: 1 }, new Date(), { x: 1 }, 'str'];
    const result = isSymmetric(inputArray);
    assert.isTrue(result, '[message]');
  });

  it('Should return false if the array is not symetric', () => {
    const inputArray = [5, 8, 2, 2, 5, 8];
    const result = isSymmetric(inputArray);
    assert.isFalse(result, '[message]');
  });
});
