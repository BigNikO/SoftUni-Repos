function dnaHelix(number) {
  let sequence = ['AT', 'CG', 'TT', 'AG', 'GG'];

  function drawLine(letters, lineVersion) {
    switch (lineVersion) {
      case 0: {
        console.log('**' + letters + '**');
        break;
      }
      case 1:
      case 3: {
        console.log(`*${letters[0]}--${letters[1]}*`);
        break;
      }
      case 2: {
        console.log(`${letters[0]}----${letters[1]}`);
        break;
      }
    }
  }
  let letters = 0;
  let lineVersion = 0;
  for (let i = 0; i < number; i++) {
    if (i > 3) {
      lineVersion = i % 4;
    } else {
      lineVersion = i;
    }
    if (letters > 4) {
      letters = 0;
    }
    drawLine(sequence[letters], lineVersion);
    letters++;
  }
}

dnaHelix(10);
