function firstLastKNums(input) {
  console.log(input.slice(1, k).join(' '));
  console.log(input.slice(input.length - input[0]).join(' '));
}

firstLastKNums([2, 2, 3, 4, 5, 6]);
