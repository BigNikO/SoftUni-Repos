const { assert } = require('chai');
const lookupChar = require('../03.CharLoopup');

describe('Function Char Look up', () => {
  it('should return undefined if the first argument is not a string', () => {
    const inputString = 5;
    const result = lookupChar(inputString, 1);
    assert.isUndefined(result);
  });

  it('should return undefined if the first argument is not a string', () => {
    const inputString = [];
    const result = lookupChar(inputString, 1);
    assert.isUndefined(result);
  });

  it('should return undefined if the first argument is not a string', () => {
    const inputString = {};
    const result = lookupChar(inputString, 1);
    assert.isUndefined(result);
  });

  it('should return undefined if the second argument argument is not an integer number', () => {
    const inputString = 'String';
    const result = lookupChar(inputString, 1.2);
    assert.isUndefined(result);
  });

  it('should return undefined if the second argument argument is not an integer number', () => {
    const inputString = 'String';
    const result = lookupChar(inputString, '1');
    assert.isUndefined(result);
  });

  it('should return "H"', () => {
    const inputString = 'Hello';
    const inputIndex = 0;
    const expected = 'H';
    const actual = lookupChar(inputString, inputIndex);
    assert.equal(actual, expected, '[message]');
  });

  it('should return "e"', () => {
    const inputString = 'Hello';
    const inputIndex = 1;
    const expected = 'e';
    const actual = lookupChar(inputString, inputIndex);
    assert.equal(actual, expected, '[message]');
  });

  it('should incorrect index', () => {
    const inputString = 'Hello';
    const inputIndex = 10;
    const expected = 'Incorrect index';
    const actual = lookupChar(inputString, inputIndex);
    assert.equal(actual, expected, '[message]');
  });

  it('should return incorrect index', () => {
    const inputString = '';
    const inputIndex = 0;
    const expected = 'Incorrect index';
    const actual = lookupChar(inputString, inputIndex);
    assert.equal(actual, expected, '[message]');
  });

  it('should return incorrect index', () => {
    const inputString = 'Hello';
    const inputIndex = -1;
    const expected = 'Incorrect index';
    const actual = lookupChar(inputString, inputIndex);
    assert.equal(actual, expected, '[message]');
  });
});
