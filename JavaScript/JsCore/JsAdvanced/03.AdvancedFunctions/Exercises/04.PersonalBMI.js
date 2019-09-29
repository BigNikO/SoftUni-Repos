function personalBMI(name, age, weight, height) {
  const heightInMeters = height / 100;
  const BMI = Math.round(weight / Math.pow(heightInMeters, 2));
  function getStatus() {
    if (BMI < 18.5) return 'underweight';
    else if (BMI < 25) return 'normal';
    else if (BMI < 30) return 'overweight';
    else return 'obese';
  }
  let personalBmiObject = {
    name,
    personalInfo: {
      age,
      weight,
      height,
    },
    BMI,
    status: getStatus(),
  };

  if (getStatus() === 'obese')
    personalBmiObject.recommendation = 'admission required';

  return personalBmiObject;
}
personalBMI('Peter', 9, 57, 137);
