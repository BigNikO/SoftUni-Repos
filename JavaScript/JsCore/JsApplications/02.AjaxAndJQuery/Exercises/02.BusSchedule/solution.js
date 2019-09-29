function solve() {
  let nextStation;
  const spanInfo = $('#info span.info');
  const departButton = $('#depart');
  const arriveButton = $('#arrive');
  let currentId = 'depot';

  function depart() {
    departButton.prop('disabled', true);
    arriveButton.prop('disabled', false);
    const url = `https://judgetests.firebaseio.com/schedule/${currentId}.json`;

    $.get(url)
      .then(loadNextStop)
      .catch(loadError);
  }

  function arrive() {
    departButton.prop('disabled', false);
    arriveButton.prop('disabled', true);
    spanInfo.text(`Arriving at ${nextStation}`);
  }

  function loadNextStop(response) {
    console.log(response);
    spanInfo.text(`Next stop ${response.name}`);
    currentId = response.next;
    nextStation = response.name;
  }

  function loadError() {
    spanInfo.text('Not Connected');
  }

  return {
    depart,
    arrive,
  };
}

let result = solve();
