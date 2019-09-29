function systemComponents(input) {
  let systems = {};
  input.forEach(element => {
    let systemName = element.split(' | ')[0];
    let componentName = element.split(' | ')[1];
    let subcomponentName = element.split(' | ')[2];
    if (systems.hasOwnProperty(systemName)) {
      if (systems[systemName].hasOwnProperty(componentName)) {
        systems[systemName][componentName].push(subcomponentName);
      } else {
        systems[systemName][componentName] = [];
        systems[systemName][componentName].push(subcomponentName);
      }
    } else {
      systems[systemName] = {};
      systems[systemName][componentName] = [];
      systems[systemName][componentName].push(subcomponentName);
    }
  });

  Object.entries(systems)
    .sort()
    .sort((a, b) => Object.entries(b[1]).length - Object.entries(a[1]).length)
    .map(system => {
      console.log(system[0]);
      Object.entries(system[1])
        .sort(
          (a, b) => Object.entries(b[1]).length - Object.entries(a[1]).length
        )
        .map(component => {
          console.log('|||' + component[0]);
          component[1].map(subcomponent =>
            console.log('||||||' + subcomponent)
          );
        });
    });
}

systemComponents([
  'SULS | Main Site | Home Page',
  'SULS | Main Site | Login Page',
  'SULS | Main Site | Register Page',
  'SULS | Judge Site | Login Page',
  'SULS | Judge Site | Submittion Page',
  'Lambda | CoreA | A23',
  'SULS | Digital Site | Login Page',
  'Lambda | CoreB | B24',
  'Lambda | CoreA | A24',
  'Lambda | CoreA | A25',
  'Lambda | CoreC | C4',
  'Indice | Session | Default Storage',
  'Indice | Session | Default Security',
]);
