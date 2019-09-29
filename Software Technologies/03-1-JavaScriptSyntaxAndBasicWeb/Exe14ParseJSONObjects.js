function ParseJSONObject(arr) {
    for (let line of arr) {
        let obj = JSON.parse((line))
        for (let key in obj){
            console.log(key[0].toUpperCase() +key.substr(1)+ ": " + obj[key])
        }
    }
}