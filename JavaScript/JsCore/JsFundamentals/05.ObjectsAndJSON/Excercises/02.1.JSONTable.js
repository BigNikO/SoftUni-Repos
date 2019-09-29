function table(input) {
  let html = `<table>\n`;
  for (let i = 0; i < input.length; i++) {
    let obj = JSON.parse(input[i]);
    html += `	<tr>\n		<td>${obj['name']}</td>\n		<td>${obj['position']}</td>\n		<td>${
      obj['salary']
    }</td>\n	</tr>\n`;
  }

  html += `</table>`;
  console.log(html);
}
