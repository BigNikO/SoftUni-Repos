const { assert } = require('chai');
const rgbToHexColor = require('../06.RGBToHex');

describe('rgbToHexColor(input)', () => {
  //invalid input lower than 0
  it('should return undefined if the color is not valid', () => {
    const result = rgbToHexColor(-1, -1, -1);
    assert.isUndefined(result, '[message]');
  });
  // Invalid input greater than 255
  it('should return undefined if the red color is not valid', () => {
    const result = rgbToHexColor(256, 0, 0);
    assert.isUndefined(result, '[message]');
  });
  it('should return undefined if the green color is not valid', () => {
    const result = rgbToHexColor(0, 256, 0);
    assert.isUndefined(result, '[message]');
  });
  it('should return undefined if the blue color is not valid', () => {
    const result = rgbToHexColor(0, 0, 256);
    assert.isUndefined(result, '[message]');
  });

  //valid input
  it('should return #000000', () => {
    const actualResult = rgbToHexColor(0, 0, 0);
    const expectedResult = '#000000';
    assert.equal(actualResult, expectedResult, '[message]');
  });
  it('should return #0C0D0E', () => {
    const actualResult = rgbToHexColor(12, 13, 14);
    const expectedResult = '#0C0D0E';
    assert.equal(actualResult, expectedResult, '[message]');
  });
  it('should return #FFFFFF', () => {
    const actualResult = rgbToHexColor(255, 255, 255);
    const expectedResult = '#FFFFFF';
    assert.equal(actualResult, expectedResult, '[message]');
  });
});
