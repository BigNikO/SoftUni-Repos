function cappyJuice(juices) {
  for (let i = 0; i < juices.length - 1; i++) {
    for (let j = Number(i) + 1; j < juices.length; j++) {
      if (juices[i].split(' => ')[0] == juices[j].split(' => ')[0]) {
        let changeElement =
          juices[i].split(' => ')[0] +
          ' => ' +
          (+juices[i].split(' => ')[1] + +juices[j].split(' => ')[1]);
        if (juices[i].split(' => ')[1] / 1000 < 1) {
          juices[j] = changeElement;
          juices[i] = 'juice => 0';
        } else {
          juices[i] = changeElement;
          juices[j] = 'juice => 0';
        }
      }
    }
  }
  juices
    .filter(juice => juice.split(' => ')[1] / 1000 >= 1)
    .map(juice => {
      result = {};
      result.juice = juice.split(' => ')[0];
      result.bottles = +juice.split(' => ')[1] / 1000;
      return result;
    })
    .map(products =>
      console.log(`${products.juice} => ${Math.floor(products.bottles)}`)
    );
}
cappyJuice([
  'Orange => 2000',
  'Peach => 1432',
  'Banana => 450',
  'Peach => 600',
  'Strawberry => 549',
]);

cappyJuice([
  'Kiwi => 234',
  'Pear => 2345',
  'Watermelon => 3456',
  'Kiwi => 4567',
  'Pear => 5678',
  'Watermelon => 6789',
]);
