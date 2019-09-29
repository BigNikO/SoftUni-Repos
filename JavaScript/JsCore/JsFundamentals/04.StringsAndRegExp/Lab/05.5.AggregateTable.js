function aggregateTable(input) {
  console.log(input.map(element => element.split('|')[1].trim()).join(', '));
  console.log(
    input
      .map(element =>
        Number(element.split('|').filter(element => Number(element)))
      )
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
