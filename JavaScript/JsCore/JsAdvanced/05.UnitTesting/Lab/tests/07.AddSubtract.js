const { assert } = require('chai');
const createCalculator = require('../07.AddSubtract');

describe('CreateCalculator function', () => {
  it('should add 5 and return 5', () => {
    const { add, get } = createCalculator();
    add(5);
    const actual = get();
    const expected = 5;
    assert.equal(actual, expected, '[message]');
  });
  it('should return 0', () => {
    const { get } = createCalculator();
    const actual = get();
    const expected = 0;
    assert.equal(actual, expected, `actual: ${actual}, expected: ${expected}`);
  });
  it('should add 15 and return 15', () => {
    const { add, get } = createCalculator();
    add(5);
    add('10');
    const actual = get();
    const expected = 15;
    assert.equal(actual, expected, '[message]');
  });
  it('should substract 5 and return -5', () => {
    const { subtract, get } = createCalculator();
    subtract(5);
    const actual = get();
    const expected = -5;
    assert.equal(actual, expected, `actual: ${actual}, expected: ${expected}`);
  });
  it('should subtract 5, add 10 and return 5', () => {
    const { add, subtract, get } = createCalculator();
    subtract(5);
    add(10);
    const actual = get();
    const expected = 5;
    assert.equal(actual, expected, `actual: ${actual}, expected: ${expected}`);
  });
  it('should subtract 5, add 10 and return 5', () => {
    const { add, subtract, get } = createCalculator();
    subtract(5);
    add(10);
    const actual = get();
    const expected = 5;
    assert.equal(actual, expected, `actual: ${actual}, expected: ${expected}`);
  });
  it('should return NaN', () => {
    const { add, get } = createCalculator();
    add('String');
    const result = get();
    assert.isNaN(result);
  });
});
