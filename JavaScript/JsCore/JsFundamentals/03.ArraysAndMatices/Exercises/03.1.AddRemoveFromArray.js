function addAndRemoveElements(commands) {
  result = [];
  for (i = 0; i < commands.length; i++) {
    if (commands[i] === 'add') {
      result.unshift(i + 1);
    } else result.shift();
  }
  if (result[0]) {
    console.log(result.reverse().join('\n'));
  } else {
    console.log('Empty');
  }
}

addAndRemoveElements(['add', 'add', 'remove', 'add', 'add']);
