function distanceIn3D(arr) {
  let x = arr[0];
  let y = arr[1];
  let z = arr[2];
  let x1 = arr[3];
  let y1 = arr[4];
  let z1 = arr[5];

  let distance = Math.sqrt(
    (x - x1) * (x - x1) + (y - y1) * (y - y1) + (z - z1) * (z - z1)
  );
  console.log(distance);
}

// distanceIn3D([1, 1, 0, 5, 4, 0]);
