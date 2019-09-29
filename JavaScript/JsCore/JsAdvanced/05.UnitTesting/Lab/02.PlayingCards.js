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

console.log('' + createCard('A', 'S'));
