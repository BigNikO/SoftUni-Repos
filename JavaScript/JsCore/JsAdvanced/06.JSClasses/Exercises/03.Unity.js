class Rat {
  constructor(name) {
    this.name = name;
    this.unitedRats = [];
  }

  unite(otherRat) {
    if (otherRat instanceof Rat)
      this.unitedRats = [...this.unitedRats, otherRat];
  }

  getRats() {
    return this.unitedRats;
  }

  toString() {
    const unitedRatLine = '\n##';
    const unitedRatsNames = this.unitedRats
      .map(rat => unitedRatLine + rat.name)
      .join('');
    return this.name + unitedRatsNames;
  }
}

const rat = new Rat('Pesho');

rat.unite(new Rat('Ivan'));
rat.unite(new Rat('Gosho'));

console.log(rat.getRats());

console.log('' + rat);
