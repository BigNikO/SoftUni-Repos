function SetValuesToIndexes(values) {
    length = values[0];
    let array = new Array(Number.parseInt(length));
    for (let i = 0; i<array.length; i++) {
        array[i]=0;
    }
    for (let i = 1; i<values.length; i++){
        let pair = values[i].split(' - ');
        let index = Number(pair[0]);
        let value = Number(pair[1]);
        array[index]=value;
    }
    for (let i = 0; i<array.length; i++) {
        console.log(array[i])
    }
}
