function carFactory(car) {
  const result = { ...car };

  const getEngine = enginePower => {
    const type =
      (enginePower <= 90 && 'Small') ||
      (enginePower <= 120 && 'Normal') ||
      (enginePower > 120 && 'Monster');

    switch (type) {
      case 'Small':
        return { power: 90, volume: 1800 };
      case 'Normal':
        return { power: 120, volume: 2400 };
      case 'Monster':
        return { power: 200, volume: 3500 };
      default:
        return null;
    }
  };

  const getCarriage = (carriage, carColor) => {
    const type = carriage;
    const color = carColor;

    return { type, color };
  };

  const getWheels = wheelsize => {
    return wheelsize % 2 !== 0
      ? new Array(4).fill(wheelsize)
      : new Array(4).fill(wheelsize - 1);
  };

  const { model, power, color, carriage, wheelsize } = result;

  resultCarriage = getCarriage(carriage, color);
  wheels = getWheels(wheelsize);
  engine = getEngine(power);

  return {
    model,
    engine,
    carriage: resultCarriage,
    wheels,
  };
}

const experiment = carFactory({
  model: 'Ferrari',
  power: 200,
  color: 'red',
  carriage: 'coupe',
  wheelsize: 21,
});

console.log(experiment);
