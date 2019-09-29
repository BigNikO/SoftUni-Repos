function autoCompany(catalogue) {
  let cars = {};
  catalogue.map(element => {
    let brand = element.split(' | ')[0];
    let model = element.split(' | ')[1];
    let producedCars = +element.split(' | ')[2];

    if (cars.hasOwnProperty(brand)) {
      if (cars[brand].hasOwnProperty(model)) {
        cars[brand][model] += producedCars;
      } else {
        cars[brand][model] = producedCars;
      }
    } else {
      cars[brand] = {};
      cars[brand][model] = +producedCars;
    }
  });
  Object.entries(cars).map(element => {
    let brand = element[0];
    console.log(brand);
    Object.entries(element[1]).map(element => {
      let model = element[0];
      let producedCars = element[1];
      console.log(`###${model} -> ${producedCars}`);
    });
  });
}

autoCompany([
  'Audi | Q7 | 1000',
  'Audi | Q6 | 100',
  'BMW | X5 | 1000',
  'BMW | X6 | 100',
  'Citroen | C4 | 123',
  'Volga | GAZ-24 | 1000000',
  'Lada | Niva | 1000000',
  'Lada | Jigula | 1000000',
  'Citroen | C4 | 22',
  'Citroen | C5 | 10',
]);
