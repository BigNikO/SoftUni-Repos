function coffeeMachine(input) {
  let incomeReport = 0;
  for (let i = 0; i < input.length; i++) {
    let totalPrice = 0;
    let insertedCoins = +input[i].split(', ')[0];
    let product = input[i].split(', ')[1];

    if (product === 'coffee') {
      totalPrice += input[i].split(', ')[2] === 'caffeine' ? 0.8 : 0.9;
      if (input[i].split(', ')[3] === 'milk') {
        totalPrice += 0.1;
        totalPrice += +input[i].split(', ')[4] !== 0 ? 0.1 : 0;
      } else {
        totalPrice += +input[i].split(', ')[3] !== 0 ? 0.1 : 0;
      }
    } else if (input[i].split(', ')[2] === 'milk') {
      totalPrice += 0.1;
      totalPrice += +input[i].split(', ')[3] !== 0 ? 0.1 : 0;
      totalPrice += 0.8;
    } else {
      totalPrice += +input[i].split(', ')[3] !== 0 ? 0.1 : 0;
      totalPrice += 0.8;
    }

    if (totalPrice > insertedCoins) {
      console.log(
        `Not enough money for ${product}. Need ${(
          totalPrice - insertedCoins
        ).toFixed(2)}$ more.`
      );
    } else {
      console.log(
        `You ordered ${product}. Price: ${totalPrice.toFixed(2)}$ Change: ${(
          insertedCoins - totalPrice
        ).toFixed(2)}$`
      );
      incomeReport += totalPrice;
    }
  }
  console.log(`Income Report: ${incomeReport.toFixed(2)}$`);
}

coffeeMachine(['8.00, coffee, decaf, 4', '1.00, tea, 2']);
