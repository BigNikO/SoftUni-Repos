function distance(arr) {
  let firstObjectSpeed = arr[0];
  let secondObjectSpeed = arr[1];
  let time = arr[2] / 3600;
  let s1 = firstObjectSpeed * time;
  let s2 = secondObjectSpeed * time;
  objectDistance = Math.abs(1000 * (s1 - s2));
  console.log(objectDistance);
}

distance([0, 60, 3600]);
