const Class = (() => {
  let counter = 0;

  return class Extensible {
    constructor() {
      this.id = counter;
      counter++;
    }

    extend(template) {
      Object.keys(template).forEach(parentProp => {
        if (typeof template[parentProp] == 'function') {
          Object.getPrototypeOf(this)[parentProp] = template[parentProp];
        } else {
          this[parentProp] = template[parentProp];
        }
      });
    }
  };
})();

const obj = new Class();
const obj1 = new Class();

console.log(obj.id);
console.log(obj1.id);
