(function extensionArray() {
  Array.prototype.last = function() {
    const arr = this;
    return arr[arr.length - 1];
  };

  Array.prototype.skip = function(count) {
    const arr = this;
    return [...arr.slice(count)];
  };

  Array.prototype.take = function(count) {
    const arr = this;
    return [...arr.slice(0, count + 1)];
  };

  Array.prototype.sum = function() {
    const arr = this;
    return arr.reduce((a, b) => a + b);
  };

  Array.prototype.average = function() {
    const arr = this;
    return arr.reduce((a, b) => a + b) / this.length;
  };
})();

let test = [1, 2, 3, 4].last();

console.log(test);
