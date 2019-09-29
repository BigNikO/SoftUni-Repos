function argumentInfoWithMap() {
  let argumentTypes = new Map();
  for (let index in arguments) {
    let type = typeof arguments[index];
    let element = arguments[index];
    console.log(`${type}: ${element}`);

    if (!argumentTypes.has(type)) {
      argumentTypes.set(type, 1);
    } else {
      argumentTypes.set(type, argumentsTypes.get(type) + 1);
    }
  }

  [...argumentTypes]
    .sort((a, b) => b[1] - a[1])
    .map(element => {
      console.log(`${element[0]} = ${element[1]}`);
    });
}

argumentInfoWithMap('cat', 42, function() {
  console.log('Hello world!');
});
