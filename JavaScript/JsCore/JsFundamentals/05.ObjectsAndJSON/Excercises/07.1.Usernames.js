function usernames(input) {
  uniqueNames = new Set();
  input.map(element => {
    uniqueNames.add(element);
  });
  [...uniqueNames]
    .sort()
    .sort((a, b) => a.length - b.length)
    .map(element => console.log(element));
}

usernames([
  'Ashton',
  'Kutcher',
  'Ariel',
  'Lilly',
  'Indie',
  'Isacc',
  'Billy',
  'Braston',
]);
