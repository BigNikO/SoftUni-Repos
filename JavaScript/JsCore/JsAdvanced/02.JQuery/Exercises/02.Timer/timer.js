function timer() {
  let hours = $('#hours');
  let minutes = $('#minutes');
  let seconds = $('#seconds');
  let interval = null;
  let currentSeconds = 0;

  let start = $('#start-timer');
  let stop = $('#stop-timer');

  start.on('click', startTimer);
  stop.on('click', stopTimer);

  function startTimer() {
    if (interval === null) {
      interval = setInterval(increment, 1000);
    }
    function increment() {
      currentSeconds++;
      hours.text(('0' + Math.floor((currentSeconds / 60 / 60) % 24)).slice(-2));
      minutes.text(('0' + Math.floor((currentSeconds / 60) % 60)).slice(-2));
      seconds.text(('0' + (currentSeconds % 60)).slice(-2));
    }
  }

  function stopTimer() {
    clearInterval(interval);
    interval = null;
  }
}
