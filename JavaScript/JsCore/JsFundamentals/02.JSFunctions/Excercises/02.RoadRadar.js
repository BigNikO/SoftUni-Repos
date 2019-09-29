function getDetails(infoDriver) {
  let zone = infoDriver[1];
  let speed = infoDriver[0];

  function getLimit() {
    switch (zone) {
      case 'motorway':
        return 130;
      case 'interstate':
        return 90;
      case 'city':
        return 50;
      case 'residential':
        return 20;
    }
  }

  let checkSpeed = getLimit(zone);

  if (speed <= checkSpeed) {
  } else if (speed <= checkSpeed + 20) {
    console.log('speeding');
  } else if (speed <= checkSpeed + 40) {
    console.log('excessive speeding');
  } else {
    console.log('reckless driving');
  }
}

getDetails([200, 'motorway']);
