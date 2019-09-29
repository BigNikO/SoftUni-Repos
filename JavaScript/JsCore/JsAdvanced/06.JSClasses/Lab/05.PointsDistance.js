class Point {
  constructor(x, y) {
    this.x = x;
    this.y = y;
  }

  static distance(point1, point2) {
    const a = Math.abs(point1.x - point2.x);
    const b = Math.abs(point1.y - point2.y);

    return Math.sqrt(a ** 2 + b ** 2);
  }
}

const point1 = new Point(5, 5);
const point2 = new Point(9, 8);

console.log(Point.distance(point1, point2));
