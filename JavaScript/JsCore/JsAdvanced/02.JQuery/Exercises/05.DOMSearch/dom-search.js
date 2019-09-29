function domSearch(selector, isCaseSensitive) {
  let addControls = $('<div>')
    .addClass('add-controls')
    .append(
      $('<label>')
        .text('Enter text')
        .append($('<input>'))
    )
    .append('<a>')
    .addClass('button')
    .css('display', 'inline-block')
    .text('Add')
    .on('click', addElement);

  let searchButoon = $('<div>')
    .addClass('search-controls')
    .append($('<input>').on('input', search));

  function addElement() {
    let elementText = $('label input');
    let newElement = $('<li>')
      .addClass('list-item')
      .append(
        $('<a>')
          .addClass('button')
          .text('X')
          .on('click', removeElement)
      )
      .append('<strong>')
      .text(elementText.val());

    $('ul.items-list').append(newElement);
    elementText.val('');
  }

  function removeElement() {
    $(this).parent.remove();
  }

  function search() {
    let searched = $(this).val();
    let elements = $('.list-item strong').toArray();
    elements.forEach(element => {
      element = $(element);

      if (isCaseSensitive) {
        element
          .parent()
          .css(
            'display',
            element.text().toLowerCase.indexOf(searched.toLowerCase()) < 0
              ? 'none'
              : ''
          );
      }
    });
  }

  let resultControls = $('<div>')
    .addClass('result-controls')
    .append($('<ul').addClass('items-list'));

  $(selector)
    .append(addControls)
    .append(searchButoon)
    .append(resultControls);
}
