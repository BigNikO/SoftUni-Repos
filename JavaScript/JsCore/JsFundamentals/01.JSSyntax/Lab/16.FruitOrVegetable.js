function fruitOrVegetable(product) {
  let fruits = [
    'banana',
    'apple',
    'kiwi',
    'cherry',
    'lemon',
    'grapes',
    'peach',
  ];
  let vegetables = [
    'tomato',
    'cucumber',
    'pepper',
    'onion',
    'garlic',
    'parsley',
  ];

  if (!(fruits.includes(product) || vegetables.includes(product))) {
    return 'unknown';
  }

  return fruits.includes(product) ? 'fruit' : 'vegetable';
}
