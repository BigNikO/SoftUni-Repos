function constructorCrew(worker) {
  const result = { ...worker };
  const alkoholIntake = 0.1;
  const gerRequiredAmount = (kilograms, yearsOfExpierence) =>
    alkoholIntake * kilograms * yearsOfExpierence;
  if (result.handsShaking) {
    const { weight, bloodAlcoholLevel, experience } = result;
    const amountOfAlcohol = gerRequiredAmount(weight, experience);
    return {
      weight,
      experience,
      bloodAlcoholLevel: bloodAlcoholLevel + amountOfAlcohol,
      handsShaking: false,
    };
  }
  return result;
}

const experiment = constructorCrew({
  weight: 95,
  experience: 3,
  bloodAlcoholLevel: 0,
  handsShaking: false,
});

console.log(experiment);
