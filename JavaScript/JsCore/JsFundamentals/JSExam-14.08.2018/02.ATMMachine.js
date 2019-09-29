function atmMachinbe(input) {
  let currenBalance = 0;
  let banknotes = [];
  for (let i = 0; i < input.length; i++) {
    if (input[i].length === 1) {
      console.log(
        `Service Report: Banknotes from ${input[i][0]}$: ${
          banknotes.filter(x => x === input[i][0]).length
        }.`
      );
    } else if (input[i].length === 2) {
      let currentAccount = +input[i][0];
      let withdraw = +input[i][1];
      if (withdraw > currentAccount) {
        console.log(
          `Not enough money in your account. Account balance: ${currentAccount}$.`
        );
      } else if (currenBalance < withdraw) {
        console.log('ATM machine is out of order!');
      } else {
        let collected = 0;
        banknotes
          .filter(a => a <= withdraw)
          .sort((a, b) => b - a)
          .map(b => {
            if (collected + b <= withdraw) {
              collected += b;
              banknotes.splice(banknotes.indexOf(b), 1);
            }
          });
        console.log(
          `You get ${+input[i][1]}$. Account balance: ${currentAccount -
            +input[i][1]}$. Thank you!`
        );
      }
    } else {
      banknotes = banknotes.concat(input[i]).sort((a, b) => b - a);
      let insertedMoney = input[i].reduce((a, b) => a + b);
      currenBalance = banknotes.reduce((a, b) => a + b);
      console.log(
        `Service Report: ${insertedMoney}$ inserted. Current balance: ${currenBalance}$.`
      );
    }
  }
}

atmMachinbe([
  [20, 5, 100, 20, 1],
  [457, 25],
  [1],
  [10, 10, 5, 20, 50, 20, 10, 5, 2, 100, 20],
  [20, 85],
  [5000, 4500],
]);
