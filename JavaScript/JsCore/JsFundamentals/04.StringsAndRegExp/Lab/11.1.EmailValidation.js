function emailValidation(email) {
  let regex = /^[a-zA-Z0-9]+@[a-zA-Z]+\.[a-zA-Z]+/g;
  if (regex.test(email)) {
    console.log('Valid');
  } else {
    console.log('Invalid');
  }
}

emailValidation('valid@email.bg');
emailValidation('invalid@email1.bg');
