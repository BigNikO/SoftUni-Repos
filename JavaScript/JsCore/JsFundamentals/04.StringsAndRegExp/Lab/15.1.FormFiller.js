function formFiller(userName, email, number, textInput) {
  regexName = /<!([A-Za-z]+)!>/;
  regexEmail = /<@([A-Za-z]+)@>/;
  regexNumber = /<\+[A-Za-z]+\+>/;
  for (i = 0; i < textInput.length; i++) {
    textInput[i] = textInput[i].replace(regexName, userName);
    textInput[i] = textInput[i].replace(regexEmail, email);
    textInput[i] = textInput[i].replace(regexNumber, number);
    console.log(textInput[i]);
  }
}

formFilter('Pesho', 'pesho@softuni.bg', '90-60-90', [
  'Hello, <!username!>!',
  'Welcome to your Personal profile.',
  'Here you can modify your profile freely.',
  'Your current username is: <!fdsfs!>. Would you like to change that? (Y/N)',
  'Your current email is: <@DasEmail@>. Would you like to change that? (Y/N)',
  'Your current phone number is: <+number+>. Would you like to change that? (Y/N)',
]);
