function assignProperties(properties) {
  firstProperty = properties[0];
  firstValue = properties[1];
  secondProperty = properties[2];
  secondValue = properties[3];
  thirdProperty = properties[4];
  thirdValue = properties[5];
  let theObject = {};
  theObject[firstProperty] = firstValue;
  theObject[secondProperty] = secondValue;
  theObject[thirdProperty] = thirdValue;

  console.log(theObject);
}

assignProperties(['name', 'Pesho', 'age', '23', 'gender', 'male']);
