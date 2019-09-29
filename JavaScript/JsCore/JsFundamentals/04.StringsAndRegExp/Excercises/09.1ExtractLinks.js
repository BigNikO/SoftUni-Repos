function extractTheLinks(inputLines) {
  let regexPatter = /w{3}\.[a-zA-Z-\d]+(\.[a-z]+)+/g;
  for (i = 0; i < inputLines.length; i++) {
    if (inputLines[i].match(regexPatter)) {
      console.log(inputLines[i].match(regexPatter).join('\n'));
    }
  }
}

extractTheLinks([
  ' information about cheap hotels in London?',
  'You can check us at www.london-hotels.co.uk!',
  'We provide the best services in London.',
  'Here are some reviews in some blogs:',
  'London Hotels are awesome!" - www.indigo.bloggers.com',
  'I am very satisfied with their services" - ww.ivan.bg',
  'Best Hotel Services!" - www.rebel21.sedecrem.moc ',
  'Join WebStars now for free, at www.web-stars.com',
  'You can also support our partners:',
  'Internet - www.internet.com',
  'WebSpiders - www.webspiders101.com',
  'Sentinel - www.sentinel.-ko ',
]);
