function extensibleObject() {
  const obj = {
    extend: template => {
      Object.keys(template).forEach(property => {
        if (typeof template[property] === 'function') {
          Object.getPrototypeOf(obj)[property] = template[property];
        } else {
          obj[property] = template[property];
        }
      });
    },
  };
  return obj;
}

extensibleObject().extend({
  extensionMethod: function() {},
  extensionProperty: 'someString',
});
