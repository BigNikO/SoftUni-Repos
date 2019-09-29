//Closures

function createCounter() {
  let counter = 0;
  return function() {
    counter++;
    return counter;
  };
}

const incrementFunction = createCounter();

const countOne = incrementFunction();
const countTwo = incrementFunction();
const countThree = incrementFunction();

console.log(countOne, countTwo, countThree);

let modelbObject = (function() {
  let count = 0;
  return {
    increase: num => (count += num),
    decrease: num => (count -= num),
    value: () => count,
  };
})();

modelbObject.increase(5);
modelbObject.increase(5);
modelbObject.increase(5);
modelbObject.increase(5);
console.log(modelbObject.value());

function modelObjectClosure() {
  let count = 0;
  return function() {
    return {
      increase: num => (count += num),
      decrease: num => (count -= num),
      value: () => count,
    };
  };
}
const getModelObject = modelObjectClosure();
const newModelObject = getModelObject();
const experimentalNewObject = modelObjectClosure()();

newModelObject.increase(5);
newModelObject.increase(5);
newModelObject.increase(5);
console.log(newModelObject.value());

experimentalNewObject.increase(5);
experimentalNewObject.increase(3);
experimentalNewObject.increase(3);
console.log(experimentalNewObject.value());
