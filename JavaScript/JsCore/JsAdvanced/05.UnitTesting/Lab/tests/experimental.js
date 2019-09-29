const sum = require('../experimental');
let assert = require('chai').assert;
let expect = require('chai').expect;


describe('sum(arr)', () => {
  it('should return 3 for [1, 2]', () => {
    expect(sum([1, 2])).equal(3);
  });
});

describe('sum(arr)', () => {
  it('should return 3 for [1, 2]', () => {
    const input = [1, 2];
    const actualResult = sum(input);
    const expectedResult = 3;
    assert.equal(actualResult, expectedResult);
  });

  it('should return -3 for [-1, -2]', () => {
    const input = [-1, -2];
    const actualResult = sum(input);
    const expectedResult = -3;
    assert.equal(actualResult, expectedResult);
  });

  it('should return -3 for [-1, -2]', () => {
    const input = [-1, -2];
    const actualResult = sum(input);
    const expectedResult = -3;
    assert.equal(actualResult, expectedResult);
  });

  it('should return 0 for []', () => {
    const input = [];
    const actualResult = sum(input);
    const expectedResult = 0;
    assert.equal(actualResult, expectedResult);
  });

  it('should throw if not array', () => {
    const input = null;
    assert.throws(() => sum(input));
  });

  it('should return NaN if contains string', () => {
    const input = [1, 'pesho'];
    result = sum(input);
    assert.isNaN(result);
  });
});
