function printCards(cards) {
  function createCard(face, suite) {
    const suites = {
      C: '\u2663', // ♣
      D: '\u2666', // ♦
      H: '\u2665', // ♥
      S: '\u2660', // ♠
    };

    const faces = [
      '2',
      '3',
      '4',
      '5',
      '6',
      '7',
      '8',
      '9',
      '10',
      'J',
      'Q',
      'K',
      'A',
    ];

    if (faces.indexOf(face) < 0 || !suites.hasOwnProperty(suite)) {
      throw new Error('Error');
    }

    return {
      toString: function() {
        return face + suites[suite];
      },
    };
  }
  let result = [];
  cards.forEach(x => {
    try {
      if (x.length === 3) {
        result.push('' + createCard(x[0] + x[1], x[2]));
      } else {
        result.push('' + createCard(x[0], x[1]));
      }
    } catch (e) {
      result = ['Invalid card: ' + x];
    }
  });

  console.log(result.join(', '));
}

printCards(['AS', '10D', 'KH', '2C']);
printCards(['5S', '3D', 'QD', '1C']);
