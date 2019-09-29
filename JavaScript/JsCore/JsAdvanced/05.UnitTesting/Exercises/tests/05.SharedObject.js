require('jsdom-global')();
const $ = require('jquery');
const { expect, assert } = require('chai');
const sharedObject = require('../05.SharedObject');

describe('sharedObject', function() {
  before(() => (global.$ = $));

  beforeEach('init the HTML', () => {
    document.body.innerHTML = `
    <div id="wrapper">
        <input type="text" id="name">
        <input type="text" id="income">
    </div>`;
  });

  describe('initially name and income should be null', function() {
    it('should return null for initial state of name', function() {
      assert.isNull(sharedObject.name);
    });
    it('should return null for initial state of income', function() {
      assert.isNull(sharedObject.income);
    });
  });

  describe('change name function', function() {
    it('should return number for number parameter', function() {
      const name = 15;
      sharedObject.changeName(name);
      console.log(sharedObject.name);

      console.log('aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa', $('#name').val());
      assert.equal(sharedObject.name, name);
      assert.equal($('#name').val(), name.toString());
    });
    it('should return previous name for empty string parameter', function() {
      sharedObject.changeName('Pesho');
      sharedObject.changeName('');
      const expected = 'Pesho';
      assert.equal(sharedObject.name, expected);
      assert.equal($('#name').val(), expected);
    });
    it('should return new name after calling the function more than one time', function() {
      sharedObject.changeName('Pesho');
      sharedObject.changeName('Gosho');
      const expected = 'Gosho';
      assert.equal(sharedObject.name, expected);
      assert.equal($('#name').val(), expected);
    });
  });

  describe('changeIncome function', function() {
    it('should return previous value after calling with 0 parameter', function() {
      sharedObject.changeIncome(5);
      sharedObject.changeIncome(0);
      const expected = 5;
      assert.equal(sharedObject.income, expected);
      assert.equal($('#income').val(), expected);
    });
    it('should return correct result after calling with integer', function() {
      sharedObject.changeIncome(10);
      const expected = 10;
      assert.equal(sharedObject.income, expected);
      assert.equal($('#income').val(), expected);
    });
    it('should return previous value after calling with negative parameter', function() {
      sharedObject.changeIncome(5);
      sharedObject.changeIncome(-10);
      const expected = 5;
      assert.equal(sharedObject.income, expected);
      assert.equal($('#income').val(), expected);
    });
  });

  describe('updateName function', function() {
    it('should successfully change name with non empty string', function() {
      sharedObject.changeName('Pesho');
      $('#name').val('Gosho');
      sharedObject.updateName();
      const expected = 'Gosho';
      assert.equal(sharedObject.name, expected);
      assert.equal($('#name').val(), expected);
    });
    it('should not change name with empty string', function() {
      sharedObject.changeName('Pesho');
      $('#name').val('');
      sharedObject.updateName();
      const expected = 'Pesho';
      assert.equal(sharedObject.name, expected);
      assert.equal($('#name').val(), '');
    });
  });

  describe('updateIncome function', function() {
    it('should return previous value if value is NaN', function() {
      sharedObject.changeIncome(15);
      $('#income').val('abc');
      sharedObject.updateIncome();
      assert.equal(sharedObject.income, 15);
      assert.equal($('#income').val(), 'abc');
    });
    it('should return previous value if value is floating point number', function() {
      sharedObject.changeIncome(15);
      $('#income').val('3.6');
      sharedObject.updateIncome();
      assert.equal(sharedObject.income, 15);
      assert.equal($('#income').val(), '3.6');
    });
    it('should return previous value if value is negative number', function() {
      sharedObject.changeIncome(15);
      $('#income').val('-10');
      sharedObject.updateIncome();
      assert.equal(sharedObject.income, 15);
      assert.equal($('#income').val(), '-10');
    });
    it('should return previous value if value is 0', function() {
      sharedObject.changeIncome(15);
      $('#income').val('0');
      sharedObject.updateIncome();
      assert.equal(sharedObject.income, 15);
      assert.equal($('#income').val(), '0');
    });
    it('should return correct value id value is positive integer', function() {
      sharedObject.changeIncome(15);
      $('#income').val('20');
      sharedObject.updateIncome();
      assert.equal(sharedObject.income, 20);
      assert.equal($('#income').val(), '20');
    });
  });
});
