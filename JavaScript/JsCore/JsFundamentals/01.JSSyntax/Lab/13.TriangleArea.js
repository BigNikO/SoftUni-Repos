function getTriangleArea(firstSide, secondSide, thirdSide) {
  console.log(
    Math.sqrt(
      ((firstSide + secondSide + thirdSide) / 2) *
        ((firstSide + secondSide + thirdSide) / 2 - firstSide) *
        ((firstSide + secondSide + thirdSide) / 2 - secondSide) *
        ((firstSide + secondSide + thirdSide) / 2 - thirdSide)
    )
  );
}
