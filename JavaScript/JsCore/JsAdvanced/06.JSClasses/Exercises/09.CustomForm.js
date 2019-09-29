const result = (() => {
  class Textbox {
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

  class Form {
    constructor(...textboxes) {
      if (textboxes.some(t => !(t instanceof Textbox))) {
        throw new Error('Some of the constructor arguments are not a Textbox');
      } else {
        this._textboxes = textboxes;
        this._element = $('<div>').addClass('form');
        for (let textbox of textboxes) {
          this._element.append($(textbox.selector));
        }
      }
    }

    submit() {
      let allValid = true;
      for (let textbox of this._textboxes) {
        if (textbox.isValid()) {
          $(textbox.selector).css('border', '2px solid green');
        } else {
          $(textbox.selector).css('border', '2px solid red');
          allValid = false;
        }
      }
      return allValid;
    }

    attach(selector) {
      $(selector).append($(this._element));
    }
  }

  return {
    Textbox,
    Form,
  };
})();

const Textbox = result.Textbox;
const Form = result.Form;
const username = new Textbox('#username', /[^a-zA-Z0-9]/);
const password = new Textbox('#password', /[^a-zA-Z]/);
username.value = 'username';
password.value = 'password2';
const form = new Form(username, password);
form.attach('#root');
