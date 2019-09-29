function imperialUnits(foots) {
  let inches = Number(foots);
  let feet = Number.parseInt(inches / 12);
  inches = inches % 12;
  console.log(`${feet}'-${inches}"`);
}

imperialUnits(36);
