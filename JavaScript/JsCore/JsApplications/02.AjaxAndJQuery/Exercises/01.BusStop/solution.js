function getInfo() {
  const stopId = $('#stopId').val();
  const api = `https://judgetests.firebaseio.com/businfo/${stopId}.json `;
  let busData = $('#buses');

  console.log(stopId);

  $.get(api)
    .then(loadBusStop)
    .catch(loadError);

  function loadBusStop(busStop) {
    busData.empty();
    $('#stopName').text(busStop.name);
    Object.keys(busStop.buses).forEach(bus => {
      $('#buses').append(
        `<li>Bus ${bus} arrives in ${busStop.buses[bus]} minutes</li>`
      );
    });
  }

  function loadError(error) {
    busData.empty();
    $('#stopName').text('Error');
  }
}
