function cookingByNumber(input) {
    let number = input[0];
    function operations(operation, number) {
        switch (operation) {
            case "chop": return number/2;
            case "dice": return Math.sqrt(number);
            case "spice": return number+1;
            case "bake": return number*3;
            case "fillet": return number*0.8;
        }
    }

    for (let i = 1; i < input.length ; i++) {
        number = operations(input[i], number);
        console.log(number);

    }
}
// cookingByNumber([32, "chop", "chop", "chop", "chop", "chop"]);
// cookingByNumber([9, "dice", 'spice', 'chop', 'bake', 'fillet']);