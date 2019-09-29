(function stringExtension() {
  String.prototype.ensureStart = function(str) {
    if (!this.startsWith(str)) {
      return str + this;
    }
    return this.toString();
  };

  String.prototype.ensureEnd = function(str) {
    if (!this.includes(str)) {
      return this + str;
    }
    return this.toString();
  };

  String.prototype.isEmpty = function() {
    return this.toString().localeCompare('') === 0;
  };

  String.prototype.truncate = function(n) {
    if (n >= this.toString().length) {
      return this.toString();
    }
    if (n <= 3) {
      return '.'.repeat(n);
    }
    const sufix = '...';
    const lastIndex = this.toString()
      .substr(0, n - 2)
      .lastIndexOf(' ');

    return lastIndex !== -1
      ? this.toString().substr(0, lastIndex) + sufix
      : this.toString(0, n - 3) + sufix;
  };

  String.format = function() {
    let result = arguments[0];
    [...arguments].slice(1).forEach((element, index) => {
      result = result.replace(`{${index}}`, element);
    });

    return result;
  };
})();

console.log('quick brown fox jumps over the lazy dog'.ensureStart('the '));
