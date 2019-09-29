function aggregateTable(input) {
  input = input.map(element =>
    element
      .split('|')
      .join('')
      .split(' ')
      .filter(element => element)
  );
  let sum = 0;
  let result = [];
  for (i = 0; i < input.length; i += 1) {
    result.push(input[i].filter(element => !Number(element)).join(' '));
    sum += Number(input[i].filter(element => Number(element)));
  }
  console.log(result.join(', '));
  console.log(sum);
}

aggregateTable([
  '| Sofia           | 300',
  '| Veliko Tarnovo  | 500',
  '| Yambol          | 275',
]);
aggregateTable([
  '| Sofia           |',
  '| Veliko Tarnovo  |',
  '| Yambol          |',
]);
