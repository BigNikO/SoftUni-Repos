function heroRegister(heroes) {
  console.log(
    JSON.stringify(
      heroes.map(element => {
        let hero = {};
        hero.name = element.split(' / ')[0];
        hero.level = +element.split(' / ')[1];
        hero.items = element.split(' / ')[2]
          ? element.split(' / ')[2].split(', ')
          : [];
        return hero;
      })
    )
  );
}

heroRegister([
  'Isacc / 25 / Apple, GravityGun',
  'Derek / 12 / BarrelVest, DestructionSword',
  'Hes / 1 / Desolator, Sentinel, Antara',
]);
