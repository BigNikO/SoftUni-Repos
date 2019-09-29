const { assert } = require('chai');
const mathEnforcer = require('../04.MathEnforcesr');

describe('Math Enforcer function', () => {
  it('should return undefined', () => {
    const { addFive } = mathEnforcer;
    const num = 'string';
    assert.isUndefined(addFive(num), '[message]');
  });
  it('should return undefined', () => {
    const { addFive } = mathEnforcer;
    const num = {};
    assert.isUndefined(addFive(num), '[message]');
  });
  it('should return undefined', () => {
    const { addFive } = mathEnforcer;
    const num = [];
    assert.isUndefined(addFive(num), '[message]');
  });
  it('should return undefined', () => {
    const { subtractTen } = mathEnforcer;
    const num = 'string';
    assert.isUndefined(subtractTen(num), '[message]');
  });
  it('should return undefined', () => {
    const { subtractTen } = mathEnforcer;
    const num = {};
    assert.isUndefined(subtractTen(num), '[message]');
  });
  it('should return undefined', () => {
    const { subtractTen } = mathEnforcer;
    const num = [];
    assert.isUndefined(subtractTen(num), '[message]');
  });
  it('should return undefined', () => {
    const { sum } = mathEnforcer;
    const firstNum = 'string';
    const secondNum = 5;
    assert.isUndefined(sum(firstNum, secondNum), '[message]');
  });
  it('should return undefined', () => {
    const { sum } = mathEnforcer;
    const firstNum = {};
    const secondNum = {};
    assert.isUndefined(sum(firstNum, secondNum), '[message]');
  });
  it('should return undefined', () => {
    const { sum } = mathEnforcer;
    const firstNum = [];
    const secondNum = [];
    assert.isUndefined(sum(firstNum, secondNum), '[message]');
  });
  it('should return undefined', () => {
    const { sum } = mathEnforcer;
    const firstNum = 5;
    const secondNum = 'string';
    assert.isUndefined(sum(firstNum, secondNum), '[message]');
  });

  it('should return 15 after add 5', () => {
    const { addFive } = mathEnforcer;
    const num = 10;
    const expected = 15;
    const actual = addFive(num);
    assert.equal(actual, expected, '[message]');
  });

  it('should return 3 after add 5', () => {
    const { addFive } = mathEnforcer;
    const num = -2;
    const expected = 3;
    const actual = addFive(num);
    assert.equal(actual, expected, '[message]');
  });

  it('should return 6.5 after add 5', () => {
    const { addFive } = mathEnforcer;
    const num = 1.5;
    const expected = 6.5;
    const actual = addFive(num);
    assert.equal(actual, expected, '[message]');
  });

  it('should return 5 after add 5', () => {
    const { addFive } = mathEnforcer;
    const num = 0;
    const expected = 5;
    const actual = addFive(num);
    assert.equal(actual, expected, '[message]');
  });

  it('should return 15 after subtract 10', () => {
    const { subtractTen } = mathEnforcer;
    const num = 25;
    const expected = 15;
    const actual = subtractTen(num);
    assert.equal(actual, expected, '[message]');
  });

  it('should return -19 after subtract 10', () => {
    const { subtractTen } = mathEnforcer;
    const num = -9;
    const expected = -19;
    const actual = subtractTen(num);
    assert.equal(actual, expected, '[message]');
  });

  it('should return 0.5 after subtract 10', () => {
    const { subtractTen } = mathEnforcer;
    const num = 10.5;
    const expected = 0.5;
    const actual = subtractTen(num);
    assert.equal(actual, expected, '[message]');
  });

  it('should return -10', () => {
    const { subtractTen } = mathEnforcer;
    const expected = -10;
    const actual = subtractTen(0);
    assert.equal(actual, expected, '[message]');
  });

  it('shoudl return 10', () => {
    const { sum } = mathEnforcer;
    const firstNum = 5;
    const secondNum = 5;
    const expected = 10;
    const actual = sum(firstNum, secondNum);
    assert.equal(actual, expected, '[message]');
  });
  it('shoudl return 3', () => {
    const { sum } = mathEnforcer;
    const firstNum = 1.5;
    const secondNum = 1.5;
    const expected = 3;
    const actual = sum(firstNum, secondNum);
    assert.equal(actual, expected, '[message]');
  });
  it('shoudl return 0', () => {
    const { sum } = mathEnforcer;
    const firstNum = -1.5;
    const secondNum = 1.5;
    const expected = 0;
    const actual = sum(firstNum, secondNum);
    assert.equal(actual, expected, '[message]');
  });
});
