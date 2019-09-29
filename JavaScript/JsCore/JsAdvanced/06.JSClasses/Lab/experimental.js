//Object.Create

const Human = {
  name: 'Pesho',
  address: 'Mladost',
  walk: () => {},
};

const obj = Object.create(Human);
console.log(obj.__proto__);

//Function - constructor

function FunHuman(name, address) {
  this.name = name || 'Pesho';
  this.address = address || 'Sofia';
  //   this.walk = () => {};
}

const newObject = new FunHuman();
const newObjectGosho = new FunHuman('Gosho', 'Plovdiv');
const newObjectIvan = Object.create(FunHuman.prototype);
FunHuman.call(newObjectIvan, 'Ivan', 'Drujba');
FunHuman.prototype.call = () => {};

console.log(newObject);
console.log(newObjectGosho);
console.log(newObjectIvan);

console.log(newObject.__proto__ === FunHuman.prototype); // true

//Javascript classes ...

class ClassHuman {
  constructor(name, address) {
    this.name = name || 'Pesho';
    this.address = address || 'Sofia';

    this._name = '';
  }

  get name() {
    return this._name;
  }

  // Setter for validations
  set name(val) {
    this._name = val;
  }

  //prototype
  walk() {}

  sleep() {}

  static eat() {}
}

const newObjectClass = new ClassHuman('GoshoClass', 'Plovdiv');

newObjectClass.name = 'Gosho';
console.log(newObjectClass.name);

console.log(newObjectClass);

return;
