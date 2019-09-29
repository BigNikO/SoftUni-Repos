function ticketScan(input, command) {
  const namePattern = / [A-Z]\w*-([A-Z]\w*\.-)?[A-Z]\w* /gm;
  const airportPatter = / [A-Z]{3}\/[A-Z]{3} /gm;
  const flightPattern = / [A-Z]{1,3}[0-9]{1,5} /gm;
  const companyPattern = /- [A-Z]\w*\*[A-Z]\w* /gm;

  const replaceSpace = / /gm;
  const replaceDash = /-/gm;
  const replaceStar = /\*/gm;

  let name = input
    .match(namePattern)[0]
    .replace(replaceSpace, '')
    .replace(replaceDash, ' ');
  let fromAirport = input
    .match(airportPatter)[0]
    .split('/')[0]
    .replace(replaceSpace, '');
  let toAirport = input
    .match(airportPatter)[0]
    .split('/')[1]
    .replace(replaceSpace, '');
  let company = input
    .match(companyPattern)[0]
    .replace(replaceSpace, '')
    .replace(replaceDash, '')
    .replace(replaceStar, ' ');
  let flight = input
    .match(flightPattern)[0]
    .replace(replaceSpace, '')
    .replace(replaceDash, ' ');

  if (command === 'name') {
    console.log(`Mr/Ms, ${name}, have a nice flight!`);
  }
  if (command === 'flight') {
    console.log(
      `Your flight number ${flight} is from ${fromAirport} to ${toAirport}.`
    );
  }
  if (command === 'company') {
    console.log(`Have a nice flight with ${company}.`);
  }
  if (command === 'all') {
    console.log(
      `Mr/Ms, ${name}, your flight number ${flight} is from ${fromAirport} to ${toAirport}. Have a nice flight with ${company}.`
    );
  }
}

ticketScan(
  ' TEST-T.-TESTOV   SOF/VIE OS806 - Austrian*Airlines T24G55 STD11:15 STA11:50',
  'flight'
);
