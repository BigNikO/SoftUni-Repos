function validate() {
  let username = $('#username');
  let email = $('#email');
  let password = $('#password');
  let confirmPass = $('#confirm-password');

  let companyCheckBox = $('#company');
  let companyInfo = $('#companyInfo ');
  let companyNumber = $('#companyNumber ');
  let button = $('#submit');
  let validationDiv = $('#valid');

  let allIsValid = true;

  companyCheckBox.on('change', isChecked);

  button.on('click', submitForm);

  function isChecked() {
    if (companyCheckBox.is(':checked')) {
      companyInfo.css('display', 'block');
    } else {
      companyInfo.css('display', 'none');
    }
  }

  function submitForm(e) {
    e.preventDefault();
    validateForm();
    validationDiv.css('display', allIsValid ? 'block' : 'none');
    allIsValid = true;
  }

  function validateForm() {
    validateInputWithRegex(username, /^[A-Za-z\d]{3,20}$/g);
    validateInputWithRegex(email, /^.*?@.*?\..*$/g);
    console.log(password.val);
    console.log(confirmPass.val);
    if (password.val() === confirmPass.val()) {
      validateInputWithRegex(password, /^\w{5,15}$/g);
      validateInputWithRegex(confirmPass, /^\w{5,15}$/g);
    } else {
      password.css('border', 'solid red');
      confirmPass.css('border', 'solid red');
      allIsValid = false;
    }
    if (companyCheckBox.is(':checked')) {
      validateInputWithRegex(companyNumber, /^[1-9]{1}[0-9]{3}$/g);
    }
  }

  function validateInputWithRegex(input, pattern) {
    if (pattern.test(input.val())) {
      input.css('border', 'none');
    } else {
      input.css('border', 'solid red');
      allIsValid = false;
    }
  }
}
