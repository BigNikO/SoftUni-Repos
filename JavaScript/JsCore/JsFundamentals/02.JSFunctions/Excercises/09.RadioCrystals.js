function radioCrystals(targetAndChunks) {
  function cut(chunk) {
    return chunk / 4;
  }

  function lap(chunk) {
    return (4 * chunk) / 5;
  }

  function grind(chunk) {
    return chunk - 20;
  }

  function etch(chunk) {
    return chunk - 2;
  }

  function xRay(chunk) {
    console.log('X-ray x1');
    return chunk + 1;
  }

  function transportAndWash(chunk) {
    console.log('Transporting and washing');
    return Math.floor(chunk);
  }

  const target = targetAndChunks[0];

  function needOperation(chunk, operationName, operationAction) {
    let counter = 0;
    chunkSize = operationAction(chunk);
    while (chunkSize >= target || Math.floor(target - chunkSize) === 1) {
      chunk = chunkSize;
      chunkSize = operationAction(chunk);
      counter += 1;
    }
    if (counter > 0) {
      console.log(`${operationName} x${counter}`);
      chunkSize = transportAndWash(chunkSize);
    }
    return chunk;
  }

  for (i = 1; i < targetAndChunks.length; i += 1) {
    console.log(`Processing chunk ${targetAndChunks[i]} microns`);
    targetAndChunks[i] = needOperation(targetAndChunks[i], 'Cut', cut);
    targetAndChunks[i] = needOperation(targetAndChunks[i], 'Lap', lap);
    targetAndChunks[i] = needOperation(targetAndChunks[i], 'Grind', grind);
    targetAndChunks[i] = needOperation(targetAndChunks[i], 'Etch', etch);

    if (targetAndChunks[i] + 1 === target) {
      targetAndChunks[i] = xRay(targetAndChunks[i]);
    }
    console.log(`Finished crystal ${targetAndChunks[i]} microns`);
  }
}
radioCrystals([1375, 50000]);
