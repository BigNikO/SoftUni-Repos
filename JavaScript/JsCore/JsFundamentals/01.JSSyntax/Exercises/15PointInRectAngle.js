function pointInReactAngle(input) {
  let x = input[0];
  let y = input[1];
  let xMin = input[2];
  let yMin = input[4];
  let xMax = input[3];
  let yMax = input[5];
  let result = '';
  if (x >= xMin && x <= xMax && y >= yMin && y <= yMax) {
    result = 'inside';
  } else {
    result = 'outside';
  }
  console.log(result);
}

// pointInReactAngle([8, -1, 2, 12, -3, 3]);