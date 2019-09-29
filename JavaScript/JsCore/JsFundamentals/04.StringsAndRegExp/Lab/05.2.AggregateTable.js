function aggregateTable(input) {
  let result = [];
  sum = 0;
  input
    .map(element =>
      element
        .split('|')
        .join('')
        .split(' ')
        .filter(element => element)
    )
    .forEach(element =>
      result.push(element.filter(town => !Number(town)).join(' '))
    );
  console.log(result.join(', '));
  input.forEach(
    element => (sum += Number(element.split('|').filter(town => Number(town))))
  );
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
