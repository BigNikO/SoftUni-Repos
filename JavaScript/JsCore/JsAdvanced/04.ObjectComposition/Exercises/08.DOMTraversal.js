function bugTracker() {
  return (() => {
    let container = [];
    let selector = undefined;
    let counter = 0;

    const report = (author, description, reproducible, severity) => {
      container[counter] = {
        ID: counter,
        author,
        description,
        reproducible,
        severity,
        status: 'Open',
      };
      counter++;

      draw();
    };

    const setStatus = (id, newStatus) => {
      container[id].status = newStatus;
      draw();
    };

    const remove = id => {
      container = container.filter(el => el.ID !== id);
      draw();
    };

    const sort = method => {
      switch (method) {
        case 'author':
          container = container.sort((a, b) =>
            a.author.localeCompare(b.author)
          );
          break;
        case 'severity':
          container = container.sort((a, b) => a.severity - b.severity);
          break;
        case 'ID':
          container = container.sort((a, b) => a.ID - b.ID);
      }

      draw();
    };

    const output = sel => {
      selector = sel;
    };

    const draw = () => {
      if (selector) {
        $(selector).html('');
        for (let bug of container) {
          $(selector).append(
            $('<div>')
              .attr('id', 'report_' + bug.ID)
              .addClass('report')
              .append(
                $('<div>')
                  .addClass('body')
                  .append($('<p>').text(bug.description))
              )
              .append(
                $('<div>')
                  .addClass('title')
                  .append(
                    $('<span>')
                      .addClass('author')
                      .text('Submitted by: ' + bug.author)
                  )
                  .append(
                    $('<span>')
                      .addClass('status')
                      .text(bug.status + ' | ' + bug.severity)
                  )
              )
          );
        }
      }
    };

    return {
      report,
      setStatus,
      remove,
      sort,
      output,
    };
  })();
}
