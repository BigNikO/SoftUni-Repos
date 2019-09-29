function colorfullNumber(numberOfColors) {
  let result = '<ul>';
  for (index = 1; index <= numberOfColors; index++) {
    let color = 'green';
    if (index % 2 == 0) {
      color = 'blue';
    }
    result += '\n';
    result += `  <li><span style='color:${color}'>${index}</span></li>`;
  }
  result += '\n';
  result += '</ul>';
  console.log(result);
}
