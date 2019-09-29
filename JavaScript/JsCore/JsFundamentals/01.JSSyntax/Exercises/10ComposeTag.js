function composeTag(components) {
  let src = components[0];
  let alt = components[1];
  console.log(`<img src="${src}" alt="${alt}">`);
}

composeTag(['smiley.gif', 'Smiley Face']);
