function MultipleValuesForAKey(values) {
    let source = {};
    for (let i = 0; i < values.length-1; i++){
        let pair = values[i].split(' ');
        let key = pair[0];
        let value = pair[1];
        source[key] = value;
    }
    let wantedKey = values[values.length-1];
    if (source.hasOwnProperty(wantedKey)) {
        for (let i = 0; i < values.length-1; i++) {
            if (values[i].split(' ')[0]==wantedKey){
                console.log(values[i].split(' ')[1])
            }
        }
    } else {
        console.log("None")
    }
}
