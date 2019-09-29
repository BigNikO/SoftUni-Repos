function attachEvents() {
  const submitButton = $('#submit');
  const url = `https://judgetests.firebaseio.com/forecast`;
  let code = null;

  submitButton.on('click', loadData);

  function temperatureConditions(condition) {
    switch (condition) {
      case 'Sunny':
        return '&#x2600';
      case 'Rain':
        return '&#x2614';
      case 'Overcast':
        return '&#x2601';
      case 'Partly sunny':
        return '&#x26C5';
    }
  }

  function loadData() {
    const location = $('#location').val();
    $('#location').val('');
    switch (location) {
      case 'New York':
        code = 'ny';
        break;
      case 'London':
        code = 'london';
        break;
      case 'Barcelona':
        code = 'barcelona';
        break;
      default:
        break;
    }

    $.get(`${url}/today/${code}.json`)
      .then(weatherToday)
      .catch(handleError);

    $.get(`${url}/upcoming/${code}.json`)
      .then(upcommingWeather)
      .catch(handleError);
  }

  function weatherToday(response) {
    const forecast = $('#forecast');
    const current = $('#current');
    $('#current span').remove();
    const weatherConditions = temperatureConditions(
      response.forecast.condition
    );
    const forecastData = [
      response.name,
      `${response.forecast.low}&#176/${response.forecast.high}&#176`,
      response.forecast.condition,
    ]
      .map(element => `<span class="forecast-data">${element}</span>`)
      .join('');
    current.append(
      $(`<span class="condition symbol">${weatherConditions}</span>`)
    );
    current.append($(`<span class="condition">`).append(`${forecastData}`));
    forecast.css('display', 'block');
  }

  function upcommingWeather(response) {
    const { forecast } = response;
    const upcoming = $('#upcoming');
    $('#upcoming span').remove();
    forecast.forEach(e => {
      const { condition, high, low } = e;
      const conditionSymbol = temperatureConditions(condition);
      const temperature = `${low}&#176/${high}&#176`;
      const forecastData = [conditionSymbol, temperature, condition]
        .map(element => {
          if (element === conditionSymbol) {
            return `<span class="condition symbol">${element}</span>`;
          }
          return `<span class="forecast-data">${element}</span>`;
        })
        .join('');
      upcoming.append($(`<span class="upcoming">${forecastData}</span>`));
    });
  }

  function handleError(error) {
    console.log(error);
  }
}
