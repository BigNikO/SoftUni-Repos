class ViewModel {
  constructor(selector, invalidSymbolsRegex) {
    this._invalidSymbols = invalidSymbolsRegex;
    this._elements = $(selector);
    $(selector).on('input', function() {
      $('*[type=text]').val(this.value);
    });
  }

  get value() {
    return this.elements.val();
  }

  set value(value) {
    this.elements.val(value);
  }

  get elements() {
    return this._elements;
  }

  isValid() {
    return !this._invalidSymbols.test(this.value);
  }
}

const textbox = new ViewModel('.textbox', /[^a-zA-Z0-9]/);
const inputs = $('.textbox');

inputs.on('input', function() {
  console.log(textbox.value);
});
