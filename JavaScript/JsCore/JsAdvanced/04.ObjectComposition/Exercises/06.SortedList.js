function sortedList() {
  return (() => {
    let collection = [];

    const sorting = (a, b) => a - b;

    const add = function(element) {
      collection = [...collection, element].sort(sorting);
      this.size++;
      return collection;
    };

    const remove = function(index) {
      if (index >= 0 && index < collection.length) {
        this.size--;
        collection.splice(index, 1).sort(sorting);

        return collection;
      }
    };

    const get = function(index) {
      if (index >= 0 && index < collection.length) {
        return collection.sort(sorting)[index];
      }
    };

    let size = 0;

    return { add, remove, get, size };
  })();
}

let list = sortedList();

console.log(list.add(5));
console.log(list.add(5));
console.log(list.add(3));
console.log(list.add(2));
console.log(list.add(5));
console.log(list.add(5));
console.log(list.add(4));
console.log(list.add(7));
console.log(list.remove(1));

console.log(list.size);
