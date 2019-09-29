function TripLength([x1, y1, x2, y2, x3, y3]) {
  function distanceBetweenPoints(x1, y1, x2, y2) {
    let deltaX = x1 - x2;
    let deltaY = y1 - y2;
    return Math.sqrt(deltaX * deltaX + deltaY * deltaY);
  }
  let distance123 =
    distanceBetweenPoints(x1, y1, x2, y2) +
    distanceBetweenPoints(x2, y2, x3, y3);
  let distance132 =
    distanceBetweenPoints(x1, y1, x3, y3) +
    distanceBetweenPoints(x3, y3, x2, y2);
  let distance213 =
    distanceBetweenPoints(x2, y2, x1, y1) +
    distanceBetweenPoints(x1, y1, x3, y3);
  let shortestDistance = Math.min(distance123, distance132, distance213);
  let shortestPath = [];
  switch (shortestDistance) {
    case distance123:
      shortestPath.push(1, 2, 3);
      break;
    case distance132:
      shortestPath.push(1, 3, 2);
      break;
    default:
      shortestPath.push(2, 1, 3);
      break;
  }
  console.log(shortestPath.join('->') + ': ' + shortestDistance);
}
TripLength([0, 0, 2, 0, 4, 0]);
