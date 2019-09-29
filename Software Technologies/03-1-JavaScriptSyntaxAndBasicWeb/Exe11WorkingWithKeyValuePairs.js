function KeyValuePairs(values) {
    let source = {};
    for (let i = 0; i < values.length-1; i++){
    let pair = values[i].split(' ');
    let key = pair[0];
    let value = pair[1];
    source[key] = value;
    }
    let wantedKey = values[values.length-1];
    if (source.hasOwnProperty(wantedKey)){
        console.log(source[wantedKey])
    } else {
        console.log('None')
    }

}
