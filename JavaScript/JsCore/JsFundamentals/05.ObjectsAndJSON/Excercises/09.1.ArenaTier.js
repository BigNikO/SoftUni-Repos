function arenaTier(input) {
  let gladiators = {};
  input.map(element => {
    if (element.includes('->')) {
      let gladiator = element.split(' -> ')[0];
      let technique = element.split(' -> ')[1];
      let skill = +element.split(' -> ')[2];

      if (gladiators.hasOwnProperty(gladiator)) {
        if (gladiators[gladiator].hasOwnProperty(technique)) {
          if (gladiators[gladiator][technique] <= skill) {
            gladiators[gladiator][technique] = skill;
          }
        } else {
          gladiators[gladiator][technique] = skill;
        }
      } else {
        gladiators[gladiator] = {};
        gladiators[gladiator][technique] = skill;
      }
    } else if (element.includes('vs')) {
      let gladiatorOne = element.split(' vs ')[0];
      let gladiatorTwo = element.split(' vs ')[1];
      if (
        gladiators.hasOwnProperty(gladiatorOne) &&
        gladiators.hasOwnProperty(gladiatorTwo)
      ) {
        let skillsOne = Object.entries(gladiators[gladiatorOne]).map(
          element => element[0]
        );
        let skillsTwo = Object.entries(gladiators[gladiatorTwo]).map(
          element => element[0]
        );
        let commonSkill;
        findSkill = skillsTwo.filter(skill =>
          skillsOne
            .filter(element => element === skill)
            .map(element => (commonSkill = element))
        );
        if (commonSkill) {
          let skillPointsOne = Object.entries(gladiators[gladiatorOne])
            .map(element => element[1])
            .reduce((a, b) => a + b);

          let skillPointsTwo = Object.entries(gladiators[gladiatorTwo])
            .map(element => element[1])
            .reduce((a, b) => a + b);

          if (skillPointsOne > skillPointsTwo) {
            delete gladiators[gladiatorTwo];
          } else if (skillPointsOne < skillPointsTwo) {
            delete gladiators[gladiatorOne];
          }
        }
      }
    }
  });

  Object.entries(gladiators)
    .sort()
    .sort(
      (a, b) =>
        Object.entries(b[1])
          .map(points => points[1])
          .reduce((x, y) => x + y) -
        Object.entries(a[1])
          .map(points => points[1])
          .reduce((x, y) => x + y)
    )
    .map(gladiator => {
      let totalPoints = Object.entries(gladiator[1])
        .map(points => points[1])
        .reduce((a, b) => a + b);
      console.log(`${gladiator[0]}: ${totalPoints} skill`);
      Object.entries(gladiator[1])
        .sort((a, b) => b[1] - a[1])
        .map(skill => {
          console.log(`- ${skill[0]} <!> ${skill[1]}`);
        });
    });
}

arenaTier([
  'Pesho -> BattleCry -> 400',
  'Gosho -> PowerPunch -> 300',
  'Stamat -> Duck -> 200',
  'Stamat -> Tiger -> 250',
  'Ave Cesar',
]);
arenaTier([
  'Pesho -> Duck -> 400',
  'Julius -> Shield -> 150',
  'Gladius -> Heal -> 200',
  'Gladius -> Support -> 250',
  'Gladius -> Shield -> 250',
  'Pesho vs Gladius',
  'Gladius vs Julius',
  'Gladius vs Gosho',
  'Ave Cesar',
]);
