function createBook(selector, bookTitle, author, isbn) {
  let bookGenerator = (function() {
    let id = 1;
    return function() {
      let mainContainer = $(selector);
      let bookContainer = $('<div>');

      bookContainer
        .css('border', 'none')
        .attr('id', `book${id}`)
        .appendTo(mainContainer);

      $('<p>')
        .addClass('title')
        .text(bookTitle)
        .appendTo(bookContainer);
      $('<p>')
        .addClass('author')
        .text(author)
        .appendTo(bookContainer);
      $('<p>')
        .addClass('isbn')
        .text(isbn)
        .appendTo(bookContainer);

      $('<button>')
        .text('Select')
        .appendTo(bookContainer)
        .on('click', select);
      $('<button>')
        .text('Deselect')
        .appendTo(bookContainer)
        .on('click', deselect);

      function select() {
        bookContainer.css('border', '2px solid blue');
      }

      function deselect() {
        bookContainer.css('border', 'none');
      }
      id++;
    };
  })();
  bookGenerator(selector, bookTitle, author, isbn);
}
