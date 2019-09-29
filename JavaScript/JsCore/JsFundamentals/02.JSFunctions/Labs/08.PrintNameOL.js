function printName(firstName, lastName) {
    if (lastName){
        console.log(firstName + ' ' +lastName);
    } else if(firstName){
        console.log(firstName)
    } else {
        console.log('No name')
    }
}

printName('Pesho');
printName('Pesho','Ivanov');
printName();