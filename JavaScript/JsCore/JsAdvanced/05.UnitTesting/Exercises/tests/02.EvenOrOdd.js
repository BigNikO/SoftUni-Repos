const { assert } = require('chai');
const isOddOrEven = require('../02.EvenOrOdd');

describe('Even ot odd function', () => {
  it('should return undefined if the input is not a string', () => {
    const input = 5;
    const result = isOddOrEven(input);
    assert.isUndefined(result);
  });
  it('should return "even"', () => {
    const expected = 'even';
    const inputString = 'ok';
    const actual = isOddOrEven(inputString);
    assert.equal(actual, expected, '[message]');
  });
  it('should return "odd"', () => {
    const expected = 'odd';
    const inputString = 'notok';
    const actual = isOddOrEven(inputString);
    assert.equal(actual, expected, '[message]');
  });
});
