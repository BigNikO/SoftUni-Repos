function multiplicationTable(number) {
  console.log('<table border="1">');
  let line = '<tr><th>x</th>';
  for (let i = 1; i <= number; i++) {
    line += `<th>${i}</th>`
  }
  console.log(line + "</tr>");
  for (let i = 1; i <= number; i++) {
    line =`<tr><th>${i}</th>`
    for (let j = i; j <= number * (i); j += i) {
      line += `<td>${j}</td>`
    }
    console.log(line + "</tr>");
  }
  console.log('</table>');
}

// multiplicationTable(10);
// multiplicationTable(5);
// multiplicationTable(7);

// document.body.innerHTML=multiplicationTable(5);