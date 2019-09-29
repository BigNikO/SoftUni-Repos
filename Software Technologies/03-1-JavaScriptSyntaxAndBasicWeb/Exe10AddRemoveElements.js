function AddRemoveElements(values) {
    length = values[0];
    let array = new Array();

    for (let action of values){
       let command = action.split(' ')[0];
       let indexValue = Number(action.split(' ')[1]);
       if (command=="add"){
           array.push(indexValue)
       }else{
           array.splice(indexValue,1)
       }
    }
    for (let i = 0; i<array.length; i++) {
        console.log(array[i])
    }
}
