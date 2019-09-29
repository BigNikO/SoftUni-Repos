function createHuman(name, eyeColor) {
  return {
    name,
    eyeColor,
    walk: () => {},
  };
}

let pavel = createHuman('Pavel', 'brown');

let mammal = {
  name: 'Sivushka',
  legs: true,
  eyes: true,
  walk: () => {},
};

let cow = Object.create(mammal);

console.log(Object.getPrototypeOf({}));

let arr = [];
let obj = {};

mammal.sound = 'Mowww';

console.log(cow.__proto__);

const { name, sound } = cow;

console.log(name);
console.log(sound);
console.log(pavel);
