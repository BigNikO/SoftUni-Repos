// with filter
function evenPosElement(array) {
  console.log(array.filter((element, index) => index % 2 === 0).join(' '));
}

evenPosElement([1, 2, 3, 4, 5, 6]);
