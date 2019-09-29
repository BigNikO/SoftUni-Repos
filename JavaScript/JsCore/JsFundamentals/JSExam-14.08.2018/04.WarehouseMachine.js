function wareHouse(input) {
  products = {};
  for (let i = 0; i < input.length; i++) {
    const command = input[i].split(', ')[0];
    let brand = input[i].split(', ')[1];
    let coffeeName = input[i].split(', ')[2];
    let date = input[i].split(', ')[3];
    let quantity = +input[i].split(', ')[4];

    if (command === 'REPORT') {
      console.log(`>>>>> REPORT! <<<<<`);
      let result = Object.entries(products);
      printProducts(result, command);
    } else if (command === 'INSPECTION') {
      console.log(`>>>>> INSPECTION! <<<<<`);
      let result = Object.entries(products).sort();
      printProducts(result, command);
    } else if (command === 'IN') {
      if (products.hasOwnProperty(brand)) {
        if (products[brand].hasOwnProperty(coffeeName)) {
          let oldDate = new Date(products[brand][coffeeName][0]);
          let newDate = new Date(date);
          if (+newDate > +oldDate) {
            products[brand][coffeeName] = [date, quantity];
          } else if (+newDate === +oldDate) {
            products[brand][coffeeName][1] += quantity;
          }
        } else {
          products[brand][coffeeName] = [date, quantity];
        }
      } else {
        products[brand] = {};
        products[brand][coffeeName] = [date, quantity];
      }
    } else {
      if (
        products.hasOwnProperty(brand) &&
        products[brand].hasOwnProperty(coffeeName)
      ) {
        let oldDate = new Date(products[brand][coffeeName][0]);
        let newDate = new Date(date);
        let oldQuantity = products[brand][coffeeName][1];
        if (+newDate < +oldDate && oldQuantity > quantity) {
          products[brand][coffeeName][1] -= quantity;
        }
      }
    }
  }
  function printProducts(productsToPrint, command) {
    if (command === 'INSPECTION') {
      productsToPrint.map(brand => {
        console.log(`Brand: ${brand[0]}:`);
        Object.entries(brand[1])
          .sort((a, b) => {
            return +b[1][1] - +a[1][1];
          })
          .map(coffee => {
            console.log(
              `-> ${coffee[0]} -> ${coffee[1][0]} -> ${coffee[1][1]}`
            );
          });
      });
    } else {
      productsToPrint.map(brand => {
        console.log(`Brand: ${brand[0]}:`);
        Object.entries(brand[1]).map(coffee => {
          console.log(`-> ${coffee[0]} -> ${coffee[1][0]} -> ${coffee[1][1]}.`);
        });
      });
    }
  }
}

wareHouse([
  'IN, Batdorf & Bronson, Espresso, 2025-05-25, 20',
  'IN, Folgers, Black Silk, 2023-03-01, 14',
  'IN, Lavazza, Crema e Gusto, 2023-05-01, 5',
  'IN, Lavazza, Crema e Gusto, 2023-05-02, 5',
  'IN, Folgers, Black Silk, 2022-01-01, 10',
  'IN, Lavazza, Intenso, 2022-07-19, 20',
  'OUT, Dallmayr, Espresso, 2022-07-19, 5',
  'OUT, Dallmayr, Crema, 2022-07-19, 5',
  'OUT, Lavazza, Crema e Gusto, 2020-01-28, 2',
  'REPORT',
  'INSPECTION',
]);
