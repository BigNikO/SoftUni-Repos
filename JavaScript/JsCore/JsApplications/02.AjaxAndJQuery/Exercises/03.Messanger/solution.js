function attachEvents() {
  const url = 'https://testapp-softuni1.firebaseio.com/messanger.json';

  const refreshButton = $('#refresh');
  const submitButton = $('#submit');
  const messages = $('#messages');

  refreshButton.on('click', refreshForm);
  submitButton.on('click', submitForm);

  function submitForm() {
    const author = $('#author').val();
    const content = $('#content').val();
    const message = {
      author,
      content,
      timestamp: Date.now(),
    };
    $.post(url, JSON.stringify(message))
      .then(sendMessage)
      .catch(loadError);

    function sendMessage() {
      messages.append(`${message.author}: ${message.content}`);
    }
  }

  function refreshForm() {
    $.get(url)
      .then(loadMessages)
      .catch(loadError);

    function loadMessages(response) {
      messages.empty();
      Object.values(response).forEach(message => {
        messages.append(`${message.author}: ${message.content}\n`);
      });
    }
  }

  function loadError(error) {
    messages.append($('<div>').text('invalid input'));
  }
}
