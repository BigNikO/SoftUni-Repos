function aggregateTable(input) {
  console.log(
    input
      .map(element =>
        element
          .split('|')
          .join('')
          .split(' ')
          .filter(element => element)
      )
      .map(element => element.filter(town => !Number(town)).join(' '))
      .join(', ')
  );
  console.log(
    input
      .map(element => Number(element.split('|').filter(town => Number(town))))
      .reduce((a, b) => a + b)
  );
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
