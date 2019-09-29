function usernames(inputEmails) {
  users = [];
  for (i = 0; i < inputEmails.length; i += 1) {
    users.push(
      inputEmails[i].split('@')[0] +
        '.' +
        inputEmails[i]
          .split('@')[1]
          .split('.')
          .map(element => element[0])
          .join('')
    );
  }
  console.log(users.join(', '));
}

usernames(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com']);
