function getConeVolumeAndArea(r, h) {
  let volume = (1 / 3) * Math.PI * (r * r) * h;
  let slantHeight = Math.sqrt(r * r + h * h);
  let lateral = Math.PI * r * slantHeight;
  let base = Math.PI * r * r;
  let totalArea = lateral + base;
  console.log(`volume = ${volume}`);
  console.log(`area = ${totalArea}`);
}
