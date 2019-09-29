function calculator(leftOperand, rightOperand, operator) {
    switch (operator) {
        case "+":
            return leftOperand + rightOperand;
        case "-":
            return leftOperand - rightOperand;
        case "*":
            return leftOperand * rightOperand;
        case "/":
            return leftOperand / rightOperand;
    }
}

//
// // console.log(calculator(1,2,'+'));
// // console.log(calculator(5,6,'-'));
// // console.log(calculator(20,4,'*'));
// // console.log(calculator(21,3,'/'));