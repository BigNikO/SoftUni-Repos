function argumentInfo() {
  let argumentTypes = {};
  for (let index in arguments) {
    let type = typeof arguments[index];
    let element = arguments[index];
    console.log(`${type}: ${element}`);

    if (!argumentTypes.hasOwnProperty(type)) {
      argumentTypes[type] = 1;
    } else {
      argumentTypes[type]++;
    }
  }
  Object.keys(argumentTypes)
    .sort((a, b) => {
      return argumentTypes[b] - argumentTypes[a];
    })
    .map(type => console.log(`${type} = ${argumentTypes[type]}`));
}
argumentInfo('cat', 42, function() {
  console.log('Hello world!');
});
