function ObjectIntoJSONStr(arr) {
    let obj = {};
    for (let line = 0; line < arr.length; line++) {
        let splitted = arr[line].split(" -> ");
        let key = splitted[0];
        let value = splitted[1];
        if (isNaN(Number(value))) {
            obj[key] = value
        } else {
            obj[key] = Number(value);
        }
    }
    console.log(JSON.stringify(obj));
}
