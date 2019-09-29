function attachEvents() {
  const url = 'https://testapp-softuni1.firebaseio.com/phonebook';
  const phoneBook = $('#phonebook');
  const createButton = $('#btnCreate');
  const loadButton = $('#btnLoad');

  createButton.on('click', createContact);
  loadButton.on('click', loadContacts);

  function createContact() {
    let person = $('#person').val();
    let phone = $('#phone').val();
    $('#person').val('');
    $('#phone').val('');
    const newContact = JSON.stringify({
      person,
      phone,
    });

    $.post(`${url}.json`, newContact)
      .then(loadContact)
      .catch(loadError);

    function loadContact(response) {
      const key = response.name;
      const li = $('<li>').text(`${person}: ${phone}`);
      li.append(
        $(` <button>`)
          .on('click', deleteContact.bind(this, key, li))
          .text('[Delete]')
      );
      phoneBook.append(li);
    }
  }

  function deleteContact(key, li) {
    $.ajax({ method: 'DELETE', url: `${url}/${key}.json` })
      .then(removeContact)
      .catch(loadError);

    function removeContact() {
      li.remove();
    }
  }

  function loadContacts() {
    $.get(`${url}.json`)
      .then(viewAll)
      .catch(loadError);

    function viewAll(contacts) {
      phoneBook.empty();
      Object.keys(contacts || '').forEach(key => {
        const li = $('<li>').text(
          `${contacts[key].person}: ${contacts[key].phone}`
        );
        li.append(
          $(` <button>`)
            .on('click', deleteContact.bind(this, key, li))
            .text('[Delete]')
        );
        phoneBook.append(li);
      });
    }
  }

  function loadError(error) {
    phoneBook.append($('<li>').text('Error'));
  }
}
