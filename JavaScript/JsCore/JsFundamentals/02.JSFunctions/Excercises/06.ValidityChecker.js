function validityChecker([x1, y1, x2, y2]) {
  isValid = (x1, y1, x2, y2) => {
    let deltaX = x1 - x2;
    let deltaY = y1 - y2;
    let distance = Math.sqrt(deltaX * deltaX + deltaY * deltaY);
    if (Number.isInteger(distance)) {
      console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    } else {
      console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }
  };

  isValid(x1, y1, 0, 0);
  isValid(x2, y2, 0, 0);
  isValid(x1, y1, x2, y2);
}

validityChecker([2, 1, 1, 1]);

// Variant 2
// function validityChecker([x1, y1, x2, y2]) {
//   isValid = (x1, x2, x3, x4, distance) => {
//     if (Number.isInteger(distance)) {
//       console.log(`{${x1}, ${x2}} to {${x3}, ${x4}} is valid`);
//     } else {
//       console.log(`{${x1}, ${x2}} to {${x3}, ${x4}} is invalid`);
//     }
//   };
//   let distance = Math.sqrt(x1 * x1 + y1 * y1);
//   isValid(x1, y1, 0, 0, distance);
//   distance = Math.sqrt(x2 * x2 + y2 * y2);
//   isValid(x2, y2, 0, 0, distance);
//   distance = Math.sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
//   isValid(x1, y1, x2, y2, distance);
// }
