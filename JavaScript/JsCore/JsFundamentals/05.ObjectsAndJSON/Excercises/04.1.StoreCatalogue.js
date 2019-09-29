function storeCatalogue(catalogue) {
  catalogue = catalogue.sort();
  let result = [];
  for (i = 0; i < catalogue.length; i++) {
    let firstLetter = catalogue[i].charAt(0);
    let element = { letter: firstLetter, products: [] };
    while (i < catalogue.length && catalogue[i].charAt(0) === firstLetter) {
      let formatElement = catalogue[i].split(' : ').join(': ');
      element.products.push(formatElement);
      i++;
    }
    result.push(element);
    i--;
  }
  result.map(element => {
    console.log(element.letter + '\n  ' + element.products.join('\n  '));
  });
}
storeCatalogue([
  'Appricot : 20.4',
  'Fridge : 1500',
  'TV : 1499',
  'Deodorant : 10',
  'Boiler : 300',
  'Apple : 1.25',
  'Anti-Bug Spray : 15',
  'T-Shirt : 10',
]);
